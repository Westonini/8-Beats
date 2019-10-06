using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This class makes the note objects move towards the button objects.
public class NoteScroller : MonoBehaviour
{
    public GameObject spawnPoint; //The gameobject at which the note will spawn and start its interpolation from.
    public GameObject endPoint;   //the gameobject at which the note will stop its interpolation at.
    private float distanceGained; //The note's distance from start to finish
    private bool reachedDestination; //Checks if the note has reached the button

    public float beatOfNote;      //The beat of the note in the song

    //Update is called once per frame
    void Update()
    {
        //Updates the distanceGained every frame. This is what essentially sets the speed of the notes.
        //The speed of the notes is determined by the songPosInBeats and noteSlowness values from Timer. noteSlowness, like the name implies, will slow down the notes. A higher value = slower notes.
        distanceGained = ((Timer.songPosInBeats + (Timer.noteSlowness - 0.1f)) - beatOfNote) / Timer.noteSlowness - 0.1f;

        //Interpolate the notes(move them) from the spawnPoint gameObject to the endPoint gameObject.
        transform.position = Vector2.Lerp(spawnPoint.transform.position, new Vector2(0, 0), distanceGained);

        //Check if the note's position is within 0.04f distance from its button's position. The note and button are never at an absolutly exact same position as each other, so this is as close as we can get.
        //If the note speed is too fast it won't be able to detect it.
        if (Vector2.Distance(transform.position, endPoint.transform.position) <= 0.04f)
        {            
            if (!reachedDestination) //Do a Debug.Log that shows some information once it approximately reaches the button position
            {
                Debug.Log("Beat of note: " + beatOfNote + "        Song position in beats: " + Timer.songPosInBeats);
            }
            reachedDestination = true;
        }

        //If the note reaches the center of the clover, destory it.
        if (transform.position == new Vector3(0, 0, 0))
        {
            Destroy(gameObject);
        }


        /* -OLD CODE-
        distanceGained = ((Timer.songPosInBeats + Timer.noteSlowness) - beatOfNote) / Timer.noteSlowness;
        transform.position = Vector2.Lerp(spawnPoint.transform.position, endPoint.transform.position, distanceGained);
        */
    }
}
