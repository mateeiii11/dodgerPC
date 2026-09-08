using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    float speed = 10f;
    public int cnt = 0;
    public float horizontal, vertical;
    public bool isDashing = false;

    Color lerpedColor = Color.white;
    public Renderer rend;
    
    void Update()
    {
        Dashh();
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    void Dashh()
    {
            if (horizontal != 0f || vertical != 0f)
            {

                if (Input.GetKey(KeyCode.LeftShift))
                {
                    FindObjectOfType<Audio>().Play("dash");
                    lerpedColor = Color.Lerp(Color.white, Color.black, 15f);
                    rend.material.color = lerpedColor;
                    if (GetComponent<slowMotion>().isSlowed == true)
                        speed = 23f;
                    else speed = 10f;
                    isDashing = true;
                    transform.position = Vector2.Lerp(transform.position, new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f) * 6 + transform.position, Time.deltaTime * speed);

                    cnt++;
                    if (cnt == 15f)
                    {
                        isDashing = false;
                        GetComponent<Dash>().enabled = false;
                    }
                }
            }
        
    }
}
