using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class collectibles : MonoBehaviour
{
    public int i;
    public int cnt;

    public Sprite[] playable;

    public static collectibles instance;
    private void Awake()
    {
        i = 2;
        cnt = 0;
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

        if (SceneManager.GetActiveScene().buildIndex == 0)
            if(cnt == 0)
            {
                i = 3;
                cnt++;
            }
    }
}
