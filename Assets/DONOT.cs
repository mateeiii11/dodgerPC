using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DONOT : MonoBehaviour, IDataPersistence
{
    public static DONOT instance;
    public bool[] hasAchieved;
    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        if (FindObjectOfType<instance>().max == 50)
            hasAchieved[2] = true;
        if (FindObjectOfType<instance>().max == 100)
            hasAchieved[1] = true;
        if (FindObjectOfType<instance>().max == 150)
            hasAchieved[0] = true;
    }
    
    public void LoadData(GameData data)
    {
        for (int i = 0; i < hasAchieved.Length; i++)
            this.hasAchieved[i] = data.hasAchieved[i];
    }

    public void SaveData(GameData data)
    {
        for (int i = 0; i < hasAchieved.Length; i++)
            data.hasAchieved[i] = this.hasAchieved[i];
    }
    
}
