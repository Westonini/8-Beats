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

    // Update is called once per frame
    void Update()
    {
        if (videoPlayer.isPlaying && Input.anyKeyDown)
        {
            //Skip cutscene
        }
    }

    public IEnumerator PlayCutscene()
    {
        AudioManager.instance.Stop("MM_Music"); //Play the main menu music at Start().

        videoPlayer.Play();
        yield return new WaitForSeconds(16.25f);
        fadeAnim.SetBool("FadeOut", true);
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(1);              //Load song select scene  
    }
}
