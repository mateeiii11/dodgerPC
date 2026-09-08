using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class highscore : MonoBehaviour
{
    public TextMeshProUGUI highScore;

    private void Start()
    {
        highScore.text = "highscore: " + FindObjectOfType<instance>().max;
    }
}
