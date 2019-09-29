using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteScroller : MonoBehaviour
{
    public Vector2 spawnPos;
    public Vector2 removePos;
    public Timer timerScript;

    public float beatOfNote;
    public float noteSlowness;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.Lerp(spawnPos, removePos, ((timerScript.songPosInBeats + noteSlowness) - beatOfNote) / noteSlowness);
    }
}
