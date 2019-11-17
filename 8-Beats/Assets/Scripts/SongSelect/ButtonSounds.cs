using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Hover and click sound of buttons
public class ButtonSounds : MonoBehaviour
{
    public string hoverSoundClip;
    public string selectSoundClip;

    //SELECT/CLICK SOUND
    public void SelectSound()
    {
        AudioManager.instance.PlayOneShot(selectSoundClip); //Play the selectSoundClip sound

    }

    //MOUSE ENTER BUTTON SOUND
    public void OnMouseEnter()
    {
        AudioManager.instance.PlayOneShot(hoverSoundClip); //When the player's mouse intially highlights the button, play the hoverSoundClip
    }
}
