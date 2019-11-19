using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Used for functionality with the main menu buttons
public class SongSelectButtons : MonoBehaviour
{
    public GameObject optionsMenu;    //Options menu panel
    private bool optionsOpen;

    public GameObject quitMenu;       //Quit menu panel
    private bool quitOpen;

    private void Start()
    {
        AudioManager.instance.Play("MM_Music"); //Play the main menu music at Start().   
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            optionsMenu.SetActive(false); //Disables the options menu panel
            optionsOpen = false;

            quitMenu.SetActive(false); //Disables the quit menu panel
            quitOpen = false;
        }
    }

    //OPTIONS MENU
    public void Options()
    {
        if (!optionsOpen)
        {
            quitMenu.SetActive(false); //Disables the quit menu panel
            quitOpen = false;

            optionsMenu.SetActive(true); //Enables the options menu panel
            optionsOpen = true;
        }
        else
        {
            optionsMenu.SetActive(false); //Disables the options menu panel
            optionsOpen = false;
        }
    }

    //QUIT BUTTON
    public void Quit()
    {
        if (!quitOpen)
        {
            optionsMenu.SetActive(false); //Disables the options menu panel
            optionsOpen = false;

            quitMenu.SetActive(true); //Enables the quit menu panel
            quitOpen = true;
        }
        else
        {
            quitMenu.SetActive(false); //Disables the quit menu panel
            quitOpen = false;
        }
    }

    //CONFIRMS QUIT
    public void ConfirmQuit()
    {
        Application.Quit(); //Quits the application
    }

    //DECLINES QUIT
    public void DeclineQuit()
    {
        quitMenu.SetActive(false); //Disables the quit menu panel
        quitOpen = false;
    }
}
