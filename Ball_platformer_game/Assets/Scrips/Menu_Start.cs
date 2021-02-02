using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Start : MonoBehaviour
{
    public void game()
    {
        SceneManager.LoadScene(2);
    }

    public void Character()
    {
        SceneManager.LoadScene(1);
    }

    public void menu()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();

    }

}
