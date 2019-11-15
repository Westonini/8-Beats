using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Manages the animations for the title screen as well as the scene transition
public class TitleScreen : MonoBehaviour
{
    Animator TSanim; //Title Screen Animator

    private void Awake()
    {
        TSanim = GetComponent<Animator>(); //Get the animatior component that's on the same gameobject as this script
    }

    void Start()
    {
        StartCoroutine("IntroAnim");            //Start the intro animation
        AudioManager.instance.Play("MM_Music"); //Play the main menu music at Start().
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
            else if (!TSanim.GetBool("Intro") && !TSanim.GetBool("Outro"))
            {
                //Start the outro animation
                StartCoroutine("OutroAnim");
            }
        }
    }

    //INTRO ANIMATION
    IEnumerator IntroAnim()
    {
        TSanim.SetBool("Intro", true);
        yield return new WaitForSeconds(2f);
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
