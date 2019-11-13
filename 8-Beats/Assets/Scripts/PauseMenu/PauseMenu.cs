using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;
    private bool countingDown = false;

    public GameObject pauseMenu;
    public TextMeshProUGUI countdownText;

    public GameObject pauseMenuPanel;
    public Animator panelAnim;

    void Start()
    {
        gameIsPaused = false; //Reset this bool to false at the start of the scene. (You need to do this just because this is a static bool)
    }

    void Update()
    {
        //ESC INPUT DETECTION
        //If the player presses the "Escape" key the game will pause or unpause
        if (Input.GetKeyDown(KeyCode.Escape) && !gameIsPaused && !countingDown && !SongFinished.songFinished && !GameOverMenu.gameOverActive)
        {
            EnablePauseMenu(true);
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && gameIsPaused && !countingDown)
        {
            EnablePauseMenu(false);
        }
    }

    //ENABLE OR DISABLE PAUSE MENU
    public void EnablePauseMenu(bool state) //true = enable; false = disable
    {
        if (state) //Enable pause menu freeze time
        {
            pauseMenuPanel.SetActive(true);                 //Enable the pause menu UI panel
            pauseMenu.SetActive(true);                      //Enable pause menu gameobjects
            panelAnim.SetBool("FadeIn", true);              //Fade in the background
            gameIsPaused = true;                            //Set the gameIsPaused bool to true

            Time.timeScale = 0f; Time.fixedDeltaTime = 0f;  //Set the timescales to zero (freezes the game)
            AudioListener.pause = true;                     //Pauses dspTime and mutes all audio
        }
        else      //Disable pause menu and unfreeze time
        {
            StartCoroutine("Countdown");                    //Start the countdown before the game unpauses
        }
    }

    //COUNTDOWN BEFORE UNPAUSE
    private IEnumerator Countdown()
    {
        pauseMenu.SetActive(false);                          //Disable pause menu panel gameobject
        countingDown = true;                                 //Set countingDown to true 
        panelAnim.SetBool("FadeIn", false);                  //Stop the background's FadeIn animation
        panelAnim.SetBool("FadeOut", true);                  //Start the background's FadeOut animation
        countdownText.color = new Color32(255, 0, 0, 255);   //Change the countdown text color to red
        countdownText.text = "3";                            //Change the countdown text to "3"

        yield return new WaitForSecondsRealtime(1f);         //Wait one second before running the following code

        countdownText.color = new Color32(255, 255, 0, 255); //Change the countdown text color to yellow
        countdownText.text = "2";                            //Change the countdown text to "2"

        yield return new WaitForSecondsRealtime(1f);         //Wait one second before running the following code

        countdownText.color = new Color32(0, 255, 0, 255);   //Change the countdown text color to green
        countdownText.text = "1";                            //Change the countdown text to "1"

        yield return new WaitForSecondsRealtime(1f);         //Wait one second before running the following code

        panelAnim.SetBool("FadeOut", false);                 //Stop the background's FadeOut animation
        countdownText.text = "";                             //Change the countdown text to nothing

        Time.timeScale = 1f; Time.fixedDeltaTime = 0.02f;    //Set the timescales to default (unfreezes the game)
        pauseMenuPanel.SetActive(false);                     //Disable the pause menu UI panel
        gameIsPaused = false;                                //Set the gameIsPaused bool to false
        countingDown = false;                                //Set countingDown bool to false

        AudioListener.pause = false;                         //Unpauses dspTime and unmutes all audio
    }
}
