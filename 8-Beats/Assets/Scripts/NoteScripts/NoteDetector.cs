using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteDetector : MonoBehaviour
{
    public bool canBePressed;
  
    public KeyCode pressedKey1;
    public KeyCode pressedKey2;

    public delegate void NoteHit();
    public static event NoteHit _noteHit;     //Event to be invoked when a note gets hit

    // Update is called once per frame
    void Update()
    {
        if((Input.GetKeyDown(pressedKey1) | Input.GetKeyDown(pressedKey2)) && !PauseMenu.gameIsPaused)
        {
            if(canBePressed)
            {
                ComboTracker.AddToComboCount();

                //Call any methods that are currently subscribed to the _noteReachedDestination event
                if (_noteHit != null)
                    _noteHit();

                gameObject.SetActive(false);
                AudioManager.instance.PlayOneShot("NoteHit");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Activator")
        {
            canBePressed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = false;
        }
    }
}
