using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public int highScore;
    public bool[] hasAchieved = new bool[3];

    public GameData()
    {
        highScore = 0;
        for (int i = 0; i < hasAchieved.Length; i++)
            hasAchieved[i] = false;
    }
}
