using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void EXIT()
    {
        //Debug.Log("pressed");

        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();  
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
