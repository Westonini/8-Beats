using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Manages the animations for the title screen as well as the scene transition
public class TitleScreen : MonoBehaviour
{
    public GameObject preTitleScreen;
    public GameObject titleScreen;
    private bool loading;

    public Animator TSanim; //Title Screen Animator

    void Start()
    {
        loading = true;

        preTitleScreen.SetActive(true); //Turn on the preTitleScreen (to give the scene time to load)
        titleScreen.SetActive(false);   //Turn off the titleScreen

        StartCoroutine("IntroAnim");            //Start the intro animation
    }

    void Update()
    {
        //If the player pushes any key down
        if (Input.anyKeyDown)
        {
            //If the intro animation is currently playing
            if (TSanim.GetBool("Intro"))
            {
                //Skip the intro animation
                TSanim.SetBool("Intro", false);
            }
            //Else if the intro animation isn't currently playing but the outro animation is playing
            else if (!TSanim.GetBool("Intro") && !TSanim.GetBool("Outro") && !loading)
            {
                //Start the outro animation
                StartCoroutine("OutroAnim");
            }
        }
    }

    //INTRO ANIMATION
    IEnumerator IntroAnim()
    {
        yield return new WaitForSeconds(0.5f); //Wait 0.5 seconds

        AudioManager.instance.Play("MM_Music"); //Play the main menu music at Start().

        yield return new WaitForSeconds(0.25f); //Wait 0.25 seconds

        //Disable the preTitleScreen, enable the titleScreen, and start the intro animation
        loading = false;
        preTitleScreen.SetActive(false);
        titleScreen.SetActive(true);
        TSanim.SetBool("Intro", true);

        yield return new WaitForSeconds(2f);  //Wait 2 seconds

        TSanim.SetBool("Intro", false);
    }

    //OUTRO ANIMATION
    IEnumerator OutroAnim()
    {
        TSanim.SetBool("Outro", true);
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(1);              //Load song select scene             
    }
}
