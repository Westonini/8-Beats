﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Stops the game and enables a game over menu
public class GameOverMenu : MonoBehaviour
{
    public GameObject gameOverMenu;
    public Animator gameOverAnim;
    public static bool gameOverActive;

    // Start is called before the first frame update
    void Start()
    {
        gameOverActive = false;
    }

    //Subscribe/Unsubscribe to _noteReachedDestination to call GameOver() whenever _noteReachedDestination gets called.
    //Gets called when this gameobject is enabled
    private void OnEnable()
    {
        NoteScroller._noteReachedDestination += GameOver;
    }
    //Gets called when this gameobject is disabled
    private void OnDisable()
    {
        NoteScroller._noteReachedDestination -= GameOver;
    }

    void GameOver()
    {
        //Don't do anything if the player's health is above 0
        if (HealthSys.health > 0)
            return;

        //Else..
        gameOverMenu.SetActive(true);                   //Enable the gameOverMenu
        StartCoroutine("GameOverFadeIn");               //Do the fade in animation for the menu
        Time.timeScale = 0f; Time.fixedDeltaTime = 0f;  //Set the timescales to zero (freezes the game)
        AudioListener.pause = true;                     //Pauses dspTime and mutes all audio      
        gameOverActive = true;                          //Sets the gameOverActive boolean to true
    }

    private IEnumerator GameOverFadeIn()
    {
        gameOverAnim.SetBool("FadeIn", true);
        yield return new WaitForSecondsRealtime(0.5f);  //Wait half a second before running the following code
        gameOverAnim.SetBool("FadeIn", false);
    }
}
