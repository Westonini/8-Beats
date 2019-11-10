using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This class makes the note objects move towards the button objects.
public class NoteScroller : MonoBehaviour
{
    public GameObject spawnPos; //The gameobject at which the note will spawn and start its interpolation from.
    public GameObject buttonPos;   //the gameobject at which the note will stop its interpolation at.
    private float distanceGained; //The note's distance from start to finish
    private bool reachedButtonPos; //Checks if the note has reached the button
    private bool reachedEndPos;       //Checks to see if the note has reached its endpoint

    public float beatOfNote;      //The beat of the note in the song

    public delegate void NoteReachedDestination();
    public event NoteReachedDestination _noteReachedDestination;            //Event to be invoked when the note reaches its final destination (0, 0)

    //Update is called once per frame
    void Update()
    {
        //Call all the following methods every frame
        InterpolateNote();
        InterpolationEndCheck();
        DebugInfo();
    }

    //NOTE MOVER
    void InterpolateNote()
    {
        //Updates the distanceGained every frame. This is what essentially sets the speed of the notes.
        //The speed of the notes is determined by the songPosInBeats and noteSlowness values from Timer. noteSlowness, like the name implies, will slow down the notes. A higher value = slower notes.
        distanceGained = ((Timer.songPosInBeats + (Timer.noteSlowness - 0.1f)) - beatOfNote) / Timer.noteSlowness - 0.1f;

        //Interpolate the notes(move them) from the spawnPoint gameObject to the the coordinates (0, 0)
        transform.position = Vector2.Lerp(spawnPos.transform.position, new Vector2(0, 0), distanceGained);

        /* -OLD CODE-
        distanceGained = ((Timer.songPosInBeats + Timer.noteSlowness) - beatOfNote) / Timer.noteSlowness;
        transform.position = Vector2.Lerp(spawnPoint.transform.position, endPoint.transform.position, distanceGained);
        */
    }

    //NOTE REACHED END-POSITION CHECK
    void InterpolationEndCheck()
    {
        //Check for when the note's position is at the coordinates (0, 0)
        if (transform.position == new Vector3(0, 0, 0) && !reachedEndPos)
        { 
            //Calls the Damage script to decrease the player's health on a miss
            HealthSys.Damage();

            //Play note miss sound
            AudioManager.instance.PlayOneShot("NoteMiss");

            //Call any methods that are currently subscribed to the _noteReachedDestination event
            if (_noteReachedDestination != null)
                _noteReachedDestination();

            reachedEndPos = true;
        }
    }

    //DEBUGGING INFORMATION
    void DebugInfo()
    {
        //Check if the note's position is within 0.04f distance from its button's position. The note and button are never at an absolutly exact same position as each other, so this is as close as we can get.
        //If the note speed is too fast it won't be able to detect it.
        if (Vector2.Distance(transform.position, buttonPos.transform.position) <= 0.04f)
        {
            if (!reachedButtonPos) //Do a Debug.Log that shows some information once it approximately reaches the button position
            {
                Debug.Log("Beat of note: " + beatOfNote + "        Song position in beats: " + Timer.songPosInBeats);
            }
            reachedButtonPos = true;
        }
    }
}
