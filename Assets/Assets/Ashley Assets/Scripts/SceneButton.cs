using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneButton : MonoBehaviour
{
    public void ExitGame() 
    {
        Application.Quit();
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Level");
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu"); 
    }
}
