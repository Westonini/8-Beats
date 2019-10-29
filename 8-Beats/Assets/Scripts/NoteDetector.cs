using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteDetector : MonoBehaviour
{
    public bool canBePressed;
  
    public KeyCode pressedKey1;
    public KeyCode pressedKey2;

    // Update is called once per frame
    void Update()
    {
        if((Input.GetKeyDown(pressedKey1) | Input.GetKeyDown(pressedKey2)) && !PauseMenu.gameIsPaused)
        {
            if(canBePressed)
            {
                gameObject.SetActive(false);
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
