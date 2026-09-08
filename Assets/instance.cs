using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class instance : MonoBehaviour, IDataPersistence
{
    
    public static instance instancee;
    public ScoreSystem refr;
    public int max = 0;
    private void Awake()
    {
        if (instancee == null)
            instancee = this;
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
    }
    
    public void SaveData(GameData data)
    {
         data.highScore = max;
    }
    

    public void LoadData(GameData data)
    {
        max = data.highScore;
    }
    

    private void Update()
    {
        refr = FindObjectOfType<ScoreSystem>();
        if (refr == null)
            return;
        if (refr.score > max)
            max = refr.score;
    }





}
