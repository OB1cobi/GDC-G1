using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSelect : MonoBehaviour
{
    public GameObject[] characters; // list of characters to be selected
    public int selectedChar = 0;
    public GameObject[] cammy; // list of cameras to activate
    public int selectedCam;
    public GameObject[] arrow; // arrow over characters head to give visual selection
    public int selectedArrow;
    
    


    private void Start()
    {
        PlayerPrefs.SetInt("selectedCam", 0);
        //PlayerPrefs.SetInt("selectedArrow", 0);
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
        //cammy[selectedCam].SetActive(true); // activates new camera

        //arrow to show next character 
        arrow[selectedArrow].SetActive(false);
        selectedArrow = (selectedArrow + 1) % arrow.Length;


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
            selectedCam += cammy.Length; // moves back one in the list of cammy's (cameras)
        }
       // cammy[selectedCam].SetActive(true); //sets current cam as true

    }

    public void Selected__()
    {
        /*if current character is "0"
         * aka the char select cam
         * then it sets it to player 1 */

        PlayerPrefs.SetInt("selectedChar", selectedChar); // sets current player as the selected one
        if (selectedChar == 0)
        {
            PlayerPrefs.SetInt("selectedChar", 1);
        }

        // same thing as character one but with cams
        PlayerPrefs.SetInt("selectedCam", selectedCam);
        if (selectedCam == 0)
        {
            PlayerPrefs.SetInt("selectedCam", 1);
        }

        cammy[selectedCam].SetActive(true); // finally set active cam as true
        cammy[0].SetActive(false); // sets the char select cam as false
        characters[0].SetActive(false); // same thing ^
        characters[selectedChar].SetActive(true);

    }


}
