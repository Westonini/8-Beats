using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuButtons : MonoBehaviour
{
    PauseMenu PM;

    private void Awake()
    {
        PM = GetComponent<PauseMenu>(); //Get the PauseMenu script
    }

    //RESUME BUTTON
    public void Resume()
    {
        PM.EnablePauseMenu(false); //Unpause the game
    }

    //RETRY BUTTON
    public void Retry()
    {
        AudioListener.pause = false;                                //Unpauses dspTime and unmutes all audio
        Time.timeScale = 1f; Time.fixedDeltaTime = 0.02f;           //Resets timescales
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //Reload the current level
    }

    //MAIN MENU BUTTON
    public void MainMenu()
    {
        AudioListener.pause = false;                      //Unpauses dspTime and unmutes all audio
        Time.timeScale = 1f; Time.fixedDeltaTime = 0.02f; //Resets timescales
        SceneManager.LoadScene(0);                        //Load the main menu scene.
    }
}
