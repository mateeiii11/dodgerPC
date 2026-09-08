using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerr : MonoBehaviour
{
    float randomIndex;
    public GameObject enemyPrefab;

    public float timeBetween = 1f;
    private float timeToSpawn = 0.5f;
    private void Update()
    {
        if (Time.time >= timeToSpawn)
        {
            SpawnEnemies();
            timeToSpawn = Time.time + timeBetween;
        }
    }
    private void SpawnEnemies()
    {
        randomIndex = Random.Range(-30f, 30f);
        Vector2 poz = new Vector2(randomIndex, 19f);

        Instantiate(enemyPrefab, poz, Quaternion.identity);
    }

}
