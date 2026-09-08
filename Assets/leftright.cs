using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class leftright : MonoBehaviour
{
    public Image[] coll;
    public collectibles refr;
    public TextMeshProUGUI[] text;
    public GameObject[] finished;
    public DONOT r;
    private void Start()
    {
        coll[refr.i].enabled = true;
        for (refr.i = 0; refr.i < coll.Length - 1; refr.i++)
            coll[refr.i].enabled = false;
        for (refr.i = 0; refr.i < text.Length; refr.i++)
            text[refr.i].enabled = false;
    }
    public void goRight()
    {
        if (refr.i == 3)
            return;
        refr.i++;
        coll[refr.i - 1].enabled = false;
        coll[refr.i].enabled = true;
        text[refr.i - 1].enabled = false;
        text[refr.i].enabled = true;  
    }

    public void goLeft()
    {
        if (refr.i == 0)
            return;
        refr.i--;
        coll[refr.i + 1].enabled = false;
        coll[refr.i].enabled = true;
        text[refr.i].enabled = true;
        text[refr.i + 1].enabled = false;

    }

    private void Update()
    {
        r = FindAnyObjectByType<DONOT>();
        refr = collectibles.FindAnyObjectByType<collectibles>();
        if (refr.i != 3)
        {
            if (r.hasAchieved[refr.i] == true)
            {
                coll[refr.i].color = Color.white;
                finished[refr.i].SetActive(false);
            }
            else
            {
                coll[refr.i].color = Color.black;
                finished[refr.i].SetActive(true);
            }
        }
    }
}
