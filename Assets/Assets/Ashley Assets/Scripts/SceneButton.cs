using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class SceneButton : MonoBehaviour
{
    public void ExitGame() 
    {
        Application.Quit();
        Debug.Log("Game Quitted");
    }

    public  void RestartGame()
    {
        EditorSceneManager.LoadScene("Restart");
        Debug.Log("Restarted");
    }
}
