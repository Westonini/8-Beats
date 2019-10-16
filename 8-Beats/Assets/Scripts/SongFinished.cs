using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Does things when the song gets finished
public class SongFinished : MonoBehaviour
{
    float songLength;
    bool sceneLoading;

    AudioSource audioSource;
    AudioClip songClip;

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); //Get the AudioSource Component from the object this script is attached to.
        songClip = audioSource.clip; //Get the AudioClip that's in the AudioSource.
        songLength = songClip.length; //Get the length (total song length) of the AudioClip.
    }

    void Update()
    {
        //If the current position in the song is equal to the song's total length + 5 seconds (meaning the song is finished and there's 5 extra seconds), load the main menu scene.
        if ((Timer.songPos >= songLength + 5) && !sceneLoading)
        {
            SceneManager.LoadScene(0); //Load main menu scene
            sceneLoading = true;
        }
    }
}
