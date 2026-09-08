using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{

    public float slowness = 10f;
    public void endGame()
    {
            StartCoroutine(restartLevel());
    }
    
    IEnumerator restartLevel()
    {
        FindObjectOfType<slowMotion>().enabled = false;
        FindObjectOfType<UIScript>().enabled = false;
        Time.timeScale = 1f / slowness;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;

        yield return new WaitForSeconds(1.5f / slowness);

        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowness;
        FindObjectOfType<slowMotion>().enabled = true;
        FindObjectOfType<UIScript>().enabled = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
