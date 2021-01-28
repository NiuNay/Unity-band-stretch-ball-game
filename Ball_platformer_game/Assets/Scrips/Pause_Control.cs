using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Control : MonoBehaviour
{
    public GameObject PauseMenu;

    private void Start()
    {
        PauseMenu.SetActive(false);
    }

    public void OnPause()
    {
        Time.timeScale = 0;
        PauseMenu.SetActive(true);
    }

    public void OnResume()
    {
        Time.timeScale = 1f;
        PauseMenu.SetActive(false);
    }

    public void OnRestart()
    {
        //UnityEngin.SceneManagement.SceneManager.LoadScene();
        Time.timeScale = 1f;
    }
}
