using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The timer class keeps track of the song's BPM, seconds per beat, and song position in order to scroll the notes accordingly.
public class Timer : MonoBehaviour
{
    public float bpm;                  //BPM of the song that's to be entered in the inspector
    public static float songPos;       //Current song position in seconds  
    public static float songPosInBeats;//Current song position in beats
    public float secondsSinceStart;    //How many seconds have passed since the song started
    public float spb;                  //Seconds per beat, or seconds between beats.

    public float firstBeatOffset;      //The offset to the first beat of the song in seconds.

    [Range(1, 10)] public float _noteSlowness; //The higher the value the slower the notes. Has a range of 1-10
    public static float noteSlowness; //The static variable for note slowness which other scripts can access.

    //Start is called before the first frame update
    void Start()
    {
        //Reset these static variables to zero at Start().
        songPos = 0f;
        songPosInBeats = 0f;
        //Sets the static noteSlowness variable to the _noteSlowness value from the inspector
        noteSlowness = _noteSlowness;
        //If the player enabled the SlowMode, half the note speed.
        if (SlowMode.slowModeEnabled)
        {
            if (noteSlowness > 1)
                noteSlowness = noteSlowness * 2;
            if (noteSlowness > 10) //Cannot be more than 10
                noteSlowness = 10;

        }
        //Number of seconds between each beat.   
        spb = 60f / bpm;
    }

    //Update is called once per frame
    void Update()
    {
        if (!StartPanel.startMenuOpen)
        {
            //determine how many seconds since the song started
            songPos = (float)(AudioSettings.dspTime - secondsSinceStart - firstBeatOffset);

            //determine how many beats since the song started. constantly set it equal to songPosition / bps so that it doesn't offset over time.
            songPosInBeats = songPos / spb;
        }
    }
}
