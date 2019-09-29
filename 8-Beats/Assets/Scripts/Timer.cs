using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float bpm;                  //BPM of the song that's to be entered in the inspector
    public float songPos;              //Current song position in seconds  
    public float songPosInBeats;  //Current song position in beats
    public float secondsSinceStart;    //How many seconds have passed since the song started
    public float spb;                  //Beats per second. Calculated by simply dividing the BPM by 60f.

    public float firstBeatOffset;      //The offset to the first beat of the song in seconds.

    // Start is called before the first frame update
    void Start()
    {
        //Number of seconds between each beat.   
        spb = 60f / bpm;

        //Saves the time as a float when the song first starts.
        secondsSinceStart = (float)AudioSettings.dspTime;
    }

    // Update is called once per frame
    void Update()
    {
        //determine how many seconds since the song started
        songPos = (float)(AudioSettings.dspTime - secondsSinceStart - firstBeatOffset);

        //determine how many beats since the song started. constantly set it equal to songPosition / bps so that it doesn't offset over time.
        songPosInBeats = songPos / spb;
    }
}
