using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Start : MonoBehaviour
{
    public static double Stretch=0;
    public static double Sensitivity=0;
    //load scene functions-----------------------
    public void loginpage()
    {
        SceneManager.LoadScene(0);
    }

    public void menu()
    {
        SceneManager.LoadScene(1);
    }

    public void Level()
    {
        SceneManager.LoadScene(2);
    }

    public void Character()
    {
        SceneManager.LoadScene(3);
    }

    public void Game1()
    {
        SceneManager.LoadScene(4);
    }

    

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

    //Select difficulty----------------------------
    public void stretchEasy()
    {
        Stretch = 0.2;
    }

    public void stretchHard()
    {
        Stretch = 0.5;
    }

    public void stretchVeryhard()
    {
        Stretch = 0.6;
    }

    public void sensitivityEasy()
    {
        Sensitivity = 5.5;
    }

    public void sensitivityHard()
    {
        Sensitivity = 6.5;
    }

    public void sensitivityVeryhard()
    {
        Sensitivity = 7.5;
    }

    //In game pause menu-------------------------

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

    public void ingamemenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }



}
