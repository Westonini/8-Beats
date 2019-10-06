﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This class makes the note objects move towards the button objects.
public class NoteScroller : MonoBehaviour
{
    public GameObject spawnPoint; //The gameobject at which the note will spawn and start its interpolation from.
    public GameObject endPoint;   //the gameobject at which the note will stop its interpolation at.

    public float beatOfNote;      //The beat of the note in the song

    //Update is called once per frame
    void Update()
    {
        //Interpolate the notes(move them) from the spawnPoint gameObject to the endPoint gameObject.
        //The speed of the notes is determined by the songPosInBeats and noteSlowness values from Timer. noteSlowness, like the name implies, will slow down the notes. A higher value = slower notes.
        transform.position = Vector2.Lerp(spawnPoint.transform.position, endPoint.transform.position, ((Timer.songPosInBeats + Timer.noteSlowness) - beatOfNote) / Timer.noteSlowness);
    }
}
