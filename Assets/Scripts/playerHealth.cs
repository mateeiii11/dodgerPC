using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    int totalHealth = 100;
    public int currentHealth;
    void Start()
    {
        currentHealth = totalHealth;
    }
    private void Update()
    {
        if (currentHealth < 0) Destroy(gameObject);
    }
    public void takeDamage(int damage)
    {
        currentHealth -= damage; 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "enemyEX")
            if (GetComponent<Dash>().isDashing == true)
                ;
            else takeDamage(40);

    }


}
