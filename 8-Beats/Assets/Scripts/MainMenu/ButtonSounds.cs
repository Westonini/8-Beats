using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Hover and click sound of buttons
public class ButtonSounds : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip selectSoundClip;

    public void Start()
    {
        audioSource.ignoreListenerPause = true; //Makes it so that audio still plays from this source when timescale is zero.
    }

    //SELECT/CLICK SOUND
    public void SelectSound()
    {
        audioSource.PlayOneShot(selectSoundClip); //Play the selectSoundClip sound
    }

    //MOUSE ENTER BUTTON SOUND
    public void OnMouseEnter()
    {
        audioSource.Play(); //When the player's mouse intially highlights the button, play the highlightSoundClip
    }
}
