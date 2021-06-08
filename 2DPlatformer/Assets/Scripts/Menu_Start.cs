using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Start : MonoBehaviour
{
    public void Game1()
    {
        SceneManager.LoadScene(2);
    }
    public void Game2()
    {
        SceneManager.LoadScene(3);
    }

    public void Character()
    {
        SceneManager.LoadScene(1);
    }

    public void menu()
    {
        SceneManager.LoadScene(0);
    }

    public void loginpage()
    {
        SceneManager.LoadScene(5);
    }

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();

    }

    //In game pause menu
    



}
