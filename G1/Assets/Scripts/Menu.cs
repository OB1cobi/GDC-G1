using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject noText;
    public void EXIT()
    {
        //Debug.Log("pressed");

        
        Application.Quit();  
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void SettingsButton()
    {
        StartCoroutine(noTextTime());

    }

    public IEnumerator noTextTime()
    {
        noText.SetActive(true);
        yield return new WaitForSeconds(1.5F);
        noText.SetActive(false);
    }
}
