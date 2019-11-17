using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Hover and click sound of buttons
public class ButtonSounds : MonoBehaviour
{
    public string hoverSoundClip;
    public string selectSoundClip;

    private Button button;

    private void Awake()
    {
        try
        {
            button = GetComponent<Button>();
        }
        catch
        {
            button = null;
        }

    }

    //SELECT/CLICK SOUND
    public void SelectSound()
    {
        if (button == null || button.enabled == true)
            AudioManager.instance.PlayOneShot(selectSoundClip); //Play the selectSoundClip sound

    }

    //MOUSE ENTER BUTTON SOUND
    public void OnMouseEnter()
    {
        if (button == null || button.enabled == true)
            AudioManager.instance.PlayOneShot(hoverSoundClip); //When the player's mouse intially highlights the button, play the hoverSoundClip
    }
}
