using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharSelect : MonoBehaviour
{
    public GameObject[] characters;
    public int selectedCharacter = 0;

    public void NextChar()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter = (selectedCharacter + 1) % characters.Length; 
        characters[selectedCharacter].SetActive(true);
    }

    public void PreviousChar()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter--;
        if (selectedCharacter < 0)
        {
            selectedCharacter += characters.Length;
        }
        characters[selectedCharacter].SetActive(true);
    }

    public void StartGame()
    {
        PlayerPrefs.SetInt("selectedchar", selectedCharacter);
        SceneManager.LoadScene(2, LoadSceneMode.Single);
    }
}