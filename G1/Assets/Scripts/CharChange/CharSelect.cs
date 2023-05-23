using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharSelect : MonoBehaviour
{
    public GameObject[] characters; // list of characters to be selected
    public int selectedChar = 0; // I made this zero to start because it made sense to me...
    public GameObject[] cammy; // list of cameras to activate
    public int selectedCam;
    public GameObject[] arrow; // arrow over characters head to give visual selection
    public int selectedArrow;
    //public bool instON; // old line for ui text turning off and on, might use later
    //public GameObject Insts; // old line for ui text turning off and on, might use later
    public GameObject[] buttons;
    public GameObject spawnPoints;
    public GameObject whiteSpawn;

    private void Start()
    {
        foreach (GameObject button in buttons)
        {
            button.SetActive(true); // turns all the ui buttons on, for choosing char
        }

        PlayerPrefs.SetInt("selectedCam", 0); // starts you at cam 0 (the char select cam)
        PlayerPrefs.SetInt("selectedArrow", 0); // starts you on arrow 0 (Im doing this for formatting sake)
        //instON = true; // old line for ui text turning off and on, might use later
        NextChar(); 
        NextChar();
        NextChar(); //I cycle through the characters 5 times in order to despawn them (if your confused remove it and look what happens)
        NextChar();
        NextChar();
        NextChar();

    }

    private void Update()
    {
        /*if (instON == false)
        //{
        //  Insts.SetActive(false); // old line for ui text turning off and on, might use later
        }*/

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OpenMenu();
        }
    }

    public void OpenMenu()
    {
        PlayerPrefs.SetInt("selectedCam", 0); // starts you at cam 0 (the char select cam)
        PlayerPrefs.SetInt("selectedArrow", 0); // starts you on arrow 0 (Im doing this for formatting sake)
        NextChar();
        NextChar();
        NextChar(); //I cycle through the characters 5 times in order to despawn them (if your confused remove it and look what happens)
        NextChar();
        NextChar();
        NextChar();
        foreach (GameObject button in buttons)
        {
            button.SetActive(true); // turns all the ui buttons on, for choosing char
        }
        Cursor.lockState = CursorLockMode.None;


       


        
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
        cammy[0].SetActive(true); // sets cam 0 as true at the end (char select screen)

        //arrow to show next character 
        arrow[selectedArrow].SetActive(false); // set current arrow as false (turning it off)
        selectedArrow = (selectedArrow + 1) % arrow.Length; // chooses next arrow in the list
        arrow[selectedArrow].SetActive(true); // activates the new arrow

    }

    public void PreviousCharacter()
    {
        //player prev activation
        characters[selectedChar].SetActive(false); // setws current character as false
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
        cammy[0].SetActive(true); // sets cam 0 as true at the end (char select screen)

        //arrow to show prev character
        arrow[selectedArrow].SetActive(false); // setws current arrow as false
        selectedArrow--; // third time around and I still dont know what this does lmao
        if (selectedArrow < 0)
        {
            selectedArrow += arrow.Length; // moves one back in the list of arrows (selects prev)
        }
        arrow[selectedArrow].SetActive(true); // sets current arrow as true!!
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
        // it doesnt seem to work for me but ill fix it later

        PlayerPrefs.SetInt("selectedArrow", selectedArrow);
       

        cammy[selectedCam].SetActive(true); // finally set active cam as true
        cammy[0].SetActive(false); // sets the char select cam as false
        characters[0].SetActive(false); // same thing ^
        characters[selectedChar].SetActive(true); // sets current character as active
        arrow[selectedArrow].SetActive(false); // turns off arrows
        //instON = false; // old line for ui text turning off and on, might use later
        
        foreach (GameObject button in buttons)
        {
            button.SetActive(false); // turns all the ui buttons off, for choosing char
        }

        

        if (selectedChar == 1)
        {
            transform.position = new Vector3(whiteSpawn.transform.position.x, whiteSpawn.transform.position.y + 1, whiteSpawn.transform.position.z);
        }
        else
        {
            characters[selectedChar].transform.position = new Vector3(spawnPoints.transform.position.x, spawnPoints.transform.position.y + 1, spawnPoints.transform.position.z);
        }

    }


}
