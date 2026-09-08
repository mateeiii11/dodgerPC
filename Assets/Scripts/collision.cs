using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collision : MonoBehaviour
{
    public int heartCounter;
    public Image[] hearts;
    public Sprite heartless;
    public Sprite heartful;
    public int i;
    public ParticleSystem ps;
    public ParticleSystem r;

    public ParticleSystem s;
    private void Start()
    {
        heartCounter = 2;
        i = heartCounter;
    }

    private void Update()
    {
        if (heartCounter < 0)
        {
            FindObjectOfType<gameManager>().endGame();
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
            if (GetComponent<playerMovementy>().isDashing == false && FindObjectOfType<playerMovementy>().isInvincible == false)
            {
                FindObjectOfType<Audio>().Play("hit");
                heartCounter--;
                hearts[i].sprite = heartless;
                i--;
                if (heartCounter > -1) ps.Play();
                Destroy(collision.gameObject);
                FindObjectOfType<ScoreSystem>().score++;

            }
            else if (GetComponent<playerMovementy>().isDashing == true || (GetComponent<playerMovementy>().isDashing == true && FindObjectOfType<playerMovementy>().isInvincible == true))
            {
                Destroy(collision.gameObject);
                FindObjectOfType<ScoreSystem>().score++;
                r.transform.position = gameObject.transform.position;
                r.Play();
            }
        }
        if (collision.gameObject.tag == "health")

            if (heartCounter <= 1)
            {
                FindObjectOfType<Audio>().Play("health");
                Destroy(collision.gameObject);
                heartCounter++;
                i++;
                s.transform.position = gameObject.transform.position;
                s.Play();
                hearts[i].sprite = heartful;
            }
    }
}

