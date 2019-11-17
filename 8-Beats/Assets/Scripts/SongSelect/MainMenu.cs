using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Used for functionality with the main menu buttons
public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;       //Main menu panel
    public GameObject songSelection;  //Song selection panel
    public GameObject optionsMenu;    //Options menu panel

    private void Start()
    {
        AudioManager.instance.Play("MM_Music"); //Play the main menu music at Start().   
    }

    //PLAY BUTTON
    public void Play()
    {
        mainMenu.SetActive(false);     //Disables the main menu panel
        songSelection.SetActive(true); //Enables the song selection panel
    }

    //OPTIONS MENU
    public void Options()
    {
        mainMenu.SetActive(false);     //Disables the main menu panel
        optionsMenu.SetActive(true); //Enables the options menu panel
    }

    //BACK BUTTON
    public void Back()
    {
        mainMenu.SetActive(true);       //Enables the main menu panel
        songSelection.SetActive(false); //Disables the song selection panel
        optionsMenu.SetActive(false);   //Disables the options menu panel
    }

    //QUIT BUTTON
    public void Quit()
    {
        Application.Quit(); //Quits the application
    }
}
