using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool menuOpen = false;

    public GameObject pauseMenu;
    public AudioSource songSource;
    private float currentAudioClipTime;

    void Start()
    {
        menuOpen = false;
    }

    void Update()
    {
        //If the player presses the "Escape" key the game pause or unpause
        if (Input.GetKeyDown(KeyCode.Escape) && !menuOpen)
        {
            EnablePauseMenu(true);
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && menuOpen)
        {
            EnablePauseMenu(false);
        }
    }

    //Enables or disables pause menu
    public void EnablePauseMenu(bool state) //true = enable; false = disable
    {
        if (state) //Enable pause menu freeze time
        {
            pauseMenu.SetActive(true);                      //Enable pause menu panel gameobject
            Time.timeScale = 0f; Time.fixedDeltaTime = 0f;  //Set the timescales to zero (freezes the game)
            menuOpen = true;                                //Set the menuOpen bool to true

            AudioListener.pause = true;                     //Pauses dspTime and mutes all audio
        }
        else      //Disable pause menu and unfreeze time
        {
            pauseMenu.SetActive(false);                     //Disable pause menu panel gameobject
            Time.timeScale = 1f; Time.fixedDeltaTime = 1f;  //Set the timescales to one (unfreezes the game)
            menuOpen = false;                               //Set the menuOpen bool to false

            AudioListener.pause = false;                    //Unpauses dspTime and unmutes all audio
        }
    }
}
