using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

//Plays a cutscene after the title screen
public class TitleScreenCutscene : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public Animator fadeAnim;
    public SpriteRenderer videoScreen;
    public GameObject skipText;

    // Update is called once per frame
    void Update()
    {
        //Skips cutscene if it's currently playing and the player presses any key
        if (videoPlayer.isPlaying && Input.anyKeyDown)
        {
            StartCoroutine("SkipEarly");
        }
    }

    //Plays a cutscene, fades out at the end, and loads the song select scene
    public IEnumerator PlayCutscene()
    {
        AudioManager.instance.Stop("MM_Music"); //Play the main menu music at Start().

        videoScreen.enabled = true;             //Enable the screen 
        videoPlayer.Play();                     //Play the video
        yield return new WaitForSeconds(1.5f);
        if (!fadeAnim.GetBool("FadeOut"))       //If it's not already fading out, meaning the player isn't skipping the cutscene yet, enable the skip text
        {
            skipText.SetActive(true);
        }
        yield return new WaitForSeconds(15f);
        fadeAnim.SetBool("FadeOut", true);      //Do a fade out transition
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(1);              //Load song select scene  
    }

    //Fades out and loads the song select scene
    public IEnumerator SkipEarly()
    {
        //Do fade out animation
        if (!fadeAnim.GetBool("FadeOut"))
        {
            fadeAnim.SetBool("FadeIn", false);
            fadeAnim.SetBool("FadeOut", true);
        }

        skipText.SetActive(false);              //Disable skip text
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(1);              //Load song select scene  
    }
}
