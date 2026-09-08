using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col : MonoBehaviour
{
    public SpriteRenderer player;

    private void Update()
    {
        if(FindObjectOfType<collectibles>().i != 3)
         if (FindObjectOfType<DONOT>().hasAchieved[FindObjectOfType<collectibles>().i] == true)
             player.sprite = FindObjectOfType<collectibles>().playable[FindObjectOfType<collectibles>().i];
        FindObjectOfType<collectibles>().cnt = 0;
    }
}
