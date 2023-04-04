using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSelect : MonoBehaviour
{
    public GameObject[] characters; // list of characters to be selected
    public int selectedChar = 0;

    public void NextChar()
    {
        characters[selectedChar].SetActive(false); //sets current selection as false
        selectedChar = (selectedChar + 1) % characters.Length; // moves up one in the list of characters
        characters[selectedChar].SetActive(true); // activates the new selection
    }

    public void PreviousCharacter()
    {
        characters[selectedChar].SetActive(false);//sets current selection as false
        selectedChar--;
        if (selectedChar <0)
        {
            selectedChar += characters.Length;// moves back one in the list of characters
        }
        characters[selectedChar].SetActive(true);// activates the new selection
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
