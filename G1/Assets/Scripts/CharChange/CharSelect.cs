using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSelect : MonoBehaviour
{
    public GameObject[] characters; // list of characters to be selected
    public int selectedChar = 0;
    public GameObject[] cammy;
    public int selectedCam;

    private void Start()
    {
        PlayerPrefs.SetInt("selectedCam", 0);
    }
    public void NextChar()
    {
        //player next activation
        characters[selectedChar].SetActive(false); // sets current selection as false
        selectedChar = (selectedChar + 1) % characters.Length; // moves up one in the list of characters
        characters[selectedChar].SetActive(true); // activates the new selection

        //cam next activation
        cammy[selectedCam].SetActive(false); // set current cam as false
        selectedCam = (selectedCam + 1) % cammy.Length; // moves up one in the list of cammy's (cameras)
        cammy[selectedCam].SetActive(true); // activates new camera
    }

    public void PreviousCharacter()
    {
        //player prev activation
        characters[selectedChar].SetActive(false); // sets current character as false
        selectedChar--;
        if (selectedChar < 0)
        {
            selectedChar += characters.Length; // moves back one in the list of characters
        }
        characters[selectedChar].SetActive(true); // activates the new selection

        //cam prev activation
        cammy[selectedCam].SetActive(false); // setws current cam as false
        selectedCam--;
        if (selectedCam < 0)
        {

        }

    }

    public void Selected__()
    {
        PlayerPrefs.SetInt("selectedChar", selectedChar); // sets current player as the selected one
        if (selectedChar == 0)
        {
            PlayerPrefs.SetInt("selectedChar", 1);
        }


    }


}
