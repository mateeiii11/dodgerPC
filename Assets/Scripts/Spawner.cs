using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject enemyPrefab;

    public float timeBetween = 1f;
    private float timeToSpawn = 2f;
    void Update()
    {
        if (Time.time >= timeToSpawn)
        {
            SpawnEnemies();
            timeToSpawn = Time.time + timeBetween;
        }
    }
    void SpawnEnemies()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            Instantiate(enemyPrefab, spawnPoints[i].position, Quaternion.identity);
        }
    }
}
