using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class probability : MonoBehaviour
{
    public GameObject ability1;
    public GameObject ability2;
    public ScoreSystem refr;
    public float cnt = 0;
    ///public float L = 0;
    ///public GameObject ability2;
    private void Update()
    {
        refr = FindObjectOfType<ScoreSystem>();
        if((int)refr.score % 35 != 0)
        {
            if ((int)refr.score % 5 == 0 && (int)refr.score != 0)
            {
                if (cnt == 0)
                {
                    spawn1();
                    spawn2();
                }
                cnt++;
            }

            if ((int)refr.score % 7 == 0)
                cnt = 0;
        }
    }

    void spawn1()
    {
        Vector2 poz = new Vector2(Random.Range(-30f, 30f), 19f);
        Instantiate(ability1, poz, Quaternion.identity);
    }

    void spawn2()
    {
        Vector2 poz = new Vector2(Random.Range(-30f, 30f), 19f);
        Instantiate(ability2, poz, Quaternion.identity);
    }
}
