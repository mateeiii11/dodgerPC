using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class slowMotion : MonoBehaviour
{
    float slow = 0.4f;
    public bool isSlowed = false;

    public float intensityVg = 0.35f;

    public Volume volume;
    ChromaticAberration cr;
    Vignette vg;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            isSlowed = true;
        if (Input.GetKeyUp(KeyCode.Space))
            isSlowed = false;
        if (isSlowed == true)
        {
            volume.profile.TryGet<Vignette>(out vg);
            {
                vg.intensity.value = intensityVg;
            }
            volume.profile.TryGet<ChromaticAberration>(out cr);
            {
                cr.intensity.value = 1;
            }
            Time.timeScale = slow;
            Time.fixedDeltaTime = Time.deltaTime;
            GetComponent<playerMovementy>().activeMoveSpeed = 47f;
        }
        else
        {
            volume.profile.TryGet<Vignette>(out vg);
            {
                vg.intensity.value = 0.25f;
            }
            volume.profile.TryGet<ChromaticAberration>(out cr);
            {
                cr.intensity.value = 0;
            }
            Time.timeScale = 1;
            Time.fixedDeltaTime = 0.02f;
            GetComponent<playerMovementy>().activeMoveSpeed = 17f;
        }
    }
}
