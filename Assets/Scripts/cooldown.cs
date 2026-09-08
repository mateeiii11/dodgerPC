using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class cooldown : MonoBehaviour
{
    public int dash_coolDown = 200;
    public bool isInvincible = false;

    Color lerpedColor = Color.black;
    public Renderer rend;

    private void Update()
    {
        if(GetComponent<Dash>().enabled == false)
        {
            isInvincible = true;
            dash_coolDown--;
            lerpedColor = Color.Lerp(Color.black, Color.white, 20f);
            if(dash_coolDown == 0)
            {
                rend.material.color = lerpedColor;
                isInvincible = false;
                GetComponent<Dash>().enabled = true;
                dash_coolDown = 200;
                GetComponent<Dash>().cnt = 0;
                GetComponent<Dash>().isDashing = false;
            }
        }

    }
}
