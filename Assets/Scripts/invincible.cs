using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invincible : MonoBehaviour
{
    public bool isInvincible = false;
    private void Update()
    {
        

    }
    /**
    IEnumerator inv()
    {
        if (GetComponent<Dash>().enabled == false)
        {
            isInvincible = true;
            yield return new WaitForSeconds(2f);
            isInvincible = false;
        }
    }
    */
}
