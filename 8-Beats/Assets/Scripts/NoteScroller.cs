using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteScroller : MonoBehaviour
{
    public float bpm;        //BPM of the song that's to be entered in the inspector
    private float beatTempo; //A.K.A. beats per second. Used for note scroll speed.

    // Start is called before the first frame update
    void Start()
    {
        //Divides the BPM by 60 seconds to get the beats per second.
        beatTempo = bpm / 60f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
