using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText;
    public GameObject enemyprefab;

    public slowMoSlider r;

    private void Start()
    {
        enemyprefab.GetComponent<Rigidbody2D>().gravityScale = 1.4f;
        r.added = 3.5f;
        score = 0; 
    }
    void Update()
    {
        score = (int)Time.timeSinceLevelLoad;
        scoreText.text = score.ToString();
        if(score == 10)
        {
            enemyprefab.GetComponent<Rigidbody2D>().gravityScale = 1.6f;
            r.added = 0.77f;

        }
        if(score == 20)
        {
            enemyprefab.GetComponent<Rigidbody2D>().gravityScale = 1.8f;
            r.added = 0.72f;
        }
        if (score == 40)
        {
            enemyprefab.GetComponent<Rigidbody2D>().gravityScale = 2f;
            r.added = 0.67f;
        }
        if (score == 60)
        {
            enemyprefab.GetComponent<Rigidbody2D>().gravityScale = 2.2f;
            r.added = 0.62f;
        }
        if (score == 80)
        {
            enemyprefab.GetComponent<Rigidbody2D>().gravityScale = 2.4f;
            r.added = 0.57f;
        }
        if (score == 100)
        {
            enemyprefab.GetComponent<Rigidbody2D>().gravityScale = 2.6f;
            r.added = 0.52f;
        }
        if (score == 120)
        {
            enemyprefab.GetComponent<Rigidbody2D>().gravityScale = 2.8f;
            r.added = 0.47f;
        }
    }
}
