using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    public GameObject pauseButton;
    public GameObject blackout;
    public GameObject menuButton;
    public GameObject pauseButton2;
    public bool isPaused;
    public Volume volume;
    LensDistortion l;

    private void Start()
    {
        pauseButton.SetActive(true);
        blackout.SetActive(false);
        menuButton.SetActive(false);
        pauseButton2.SetActive(false);
        isPaused = false;
        volume.profile.TryGet<LensDistortion>(out l) ;
        {
            l.active = true;
        }
    }

    public void pause()
    {
        blackout.SetActive(true);
        menuButton.SetActive(true);
        pauseButton2.SetActive(true);
        pauseButton.SetActive(false);
        isPaused = true;
        volume.profile.TryGet<LensDistortion>(out l);
        {
            l.active = false;
        }

    }

    public void getBackToGame()
    {
        blackout.SetActive(false);
        menuButton.SetActive(false);
        pauseButton2.SetActive(false);
        pauseButton.SetActive(true);
        isPaused = false;
        volume.profile.TryGet<LensDistortion>(out l);
        {
            l.active = true;
        }
    }

    public void BackToMenu()
    {
        DataPersistenceManager.instance.SaveGame();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    private void Update()
    {
        if (isPaused == true)
        {
            FindObjectOfType<slowMotion>().enabled = false;
            FindObjectOfType<gameManager>().enabled = false;
            Time.timeScale = 0f;
        }
        else if (isPaused == false)
        {
            FindObjectOfType<slowMotion>().enabled = true;
            FindObjectOfType<gameManager>().enabled = true;
            Time.timeScale = 1f;
        }
    }


}
