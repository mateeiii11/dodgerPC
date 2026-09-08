using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    [Header("MenuUI")]
    public GameObject menuUI;

    [Header("SettingsUI")]
    public GameObject settingsUI;
    public GameObject musicOn;
    public GameObject musicOff;
    public GameObject perfOn;
    public GameObject perfOff;

    ///public GameObject arrow;

    void Start()
    {
        menuUI.SetActive(true);
        settingsUI.SetActive(false);
    }
    public void Play()
    {
        DataPersistenceManager.instance.SaveGame();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void backToMenuSettings()
    {
        settingsUI.SetActive(false);
        menuUI.SetActive(true);
    }
    public void MusicOnOff()
    {
        musicOn.SetActive(false);
        musicOff.SetActive(true);
    }

    public void MusicOffOn()
    {
        musicOn.SetActive(true);
        musicOff.SetActive(false);
    }
    public void PerfOnOff()
    {
        perfOn.SetActive(false);
        perfOff.SetActive(true);
    }

    public void PerfOffOn()
    {
        perfOn.SetActive(true);
        perfOff.SetActive(false);
    }

    public void Exit()
    {
        DataPersistenceManager.instance.SaveGame();
        Application.Quit();
    }

    
}
