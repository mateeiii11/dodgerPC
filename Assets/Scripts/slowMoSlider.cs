using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slowMoSlider : MonoBehaviour
{
    public Slider slider;
    public slowMotion reference;
    public float added = 0.8f;
    private void Start()
    {
        slider.maxValue = 1000f;
        slider.value = slider.maxValue;
    }

    private void Update()
    {
        slowBar();
    }

    private void slowBar()
    {
        if (slider.value == 0f) reference.isSlowed = false;
        if (reference.isSlowed == false)
            slider.value += added;
        if (reference.isSlowed == true)
            slider.value -= 3.5f;
    }
}
