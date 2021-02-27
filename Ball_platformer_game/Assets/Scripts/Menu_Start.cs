using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Start : MonoBehaviour
{
    public void Game1()
    {
        SceneManager.LoadScene(3);
    }
    public void Game2()
    {
        SceneManager.LoadScene(4);
    }

    public void Character()
    {
        SceneManager.LoadScene(2);
    }

    public void menu()
    {
        SceneManager.LoadScene(0);
    }

    public void Level()
    {
        SceneManager.LoadScene(1);

    }

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();

    }

    //In game pause menu
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
