using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{

    public void EXIT()
    {
        //Debug.Log("pressed");

        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
       
    }
}
