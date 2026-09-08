using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dashBro : MonoBehaviour
{
    public int dashCounter;
    public Image[] dashBars;
    public Sprite dashFul;
    public Sprite dashLess;
    public int i;
    public bool Dash;
    public int cnt;
    public ParticleSystem p;
    void Start()
    {
        dashCounter = 2;
        i = dashCounter;
        Dash = true;
        cnt = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (dashCounter < 0)
        {
            Dash = false;
        }
        else if (dashCounter >= 0)
            Dash = true;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (FindObjectOfType<playerMovementy>().horizontal != 0f || FindObjectOfType<Dash>().vertical != 0f)
            {
                if (cnt == 1)
                {
                    cnt--;
                    dashBars[i].sprite = dashLess;
                    i--;
                    dashCounter--;
                }
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "dashGiver")
        {
            if (dashCounter <= 1)
            {
                FindObjectOfType<Audio>().Play("dashGiver");
                Destroy(collision.gameObject);
                dashCounter++;
                i++;
                p.transform.position = gameObject.transform.position;
                p.Play();
                dashBars[i].sprite = dashFul;
            }
        }
    }
}
