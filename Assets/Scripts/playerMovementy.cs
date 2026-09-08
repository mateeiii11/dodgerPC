using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovementy : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;

    public float horizontal, vertical;

    public float activeMoveSpeed;
    public float dashSpeed;

    public float dashLenght = 0.5f, dashCOoldown = 1f;

    private float dashCounter = 0f;
    private float dashCoolCounter = 0f;

    public bool isDashing = false;
    public bool isInvincible = false;

    Vector2 direction;

    public static playerMovementy instance;

    public Renderer rend;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        activeMoveSpeed = speed;
    }
    private void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        direction = new Vector2(horizontal, vertical);
        Dash();
    }
    private void FixedUpdate()
    {
        Movement(direction);
        ///rb.velocity = direction * activeMoveSpeed * Time.fixedDeltaTime;
    }

    // MOVEMENT
    void Movement(Vector2 movement)
    {
        rb.MovePosition(rb.position + movement * activeMoveSpeed * Time.fixedDeltaTime);
    }

    public void Dash()
    {
        if (GetComponent<dashBro>().Dash == true)
            if (horizontal != 0f || vertical != 0f)
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    GetComponent<slowMotion>().enabled = false;
                    if (dashCoolCounter <= 0 && dashCounter <= 0)
                    {

                        activeMoveSpeed = dashSpeed;
                        dashCounter = dashLenght;
                        isDashing = true;
                        isInvincible = true;
                        FindObjectOfType<Audio>().Play("dash");
                        rend.material.color = Color.Lerp(Color.white, Color.black, 15f);
                    }
                }

        if (dashCounter > 0)
        {
            dashCounter -= Time.deltaTime;
            if (dashCounter <= 0)
            {
                activeMoveSpeed = speed;
                dashCoolCounter = dashCOoldown;
            }
        }

        if (dashCoolCounter > 0)
        {
            GetComponent<slowMotion>().enabled = true;
            isDashing = false;
            dashCoolCounter -= Time.deltaTime;
            if (dashCoolCounter <= 0)
            {
                isInvincible = false;
                rend.material.color = Color.Lerp(Color.black, Color.white, 15f);
                GetComponent<dashBro>().cnt = 1;
            }
        }
    }
}
