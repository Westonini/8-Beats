using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Check if the song has finished playing. Enable results menu if it finished.
public class SongFinished : MonoBehaviour
{
    float songLength;
    static public bool songFinished;

    public ResultsMenu rm;

    AudioSource audioSource;
    AudioClip songClip;

    void Start()
    {
        songFinished = false;

        audioSource = GetComponent<AudioSource>(); //Get the AudioSource Component from the object this script is attached to.
        songClip = audioSource.clip; //Get the AudioClip that's in the AudioSource.
        songLength = songClip.length; //Get the length (total song length) of the AudioClip.
    }

    void Update()
    {
        //If the current position in the song is equal to the song's total length + 5 seconds (meaning the song is finished and there's 5 extra seconds), set the songFinished boolean to true.
        if ((Timer.songPos >= songLength + 2.5f) && !songFinished)
        {
            rm.EnableResultsMenu();
            songFinished = true;
        }
    }
}
