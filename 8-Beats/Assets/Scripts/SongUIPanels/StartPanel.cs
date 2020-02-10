using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPanel : MonoBehaviour
{
    public GameObject textGlow;
    public GameObject startPanel;
    public Animator startPanelAnim;
    public static bool startMenuOpen;

    public Timer timerScript;

    // Start is called before the first frame update
    void Start()
    {
        startPanel.SetActive(true);

        startMenuOpen = true; //Reset the startMenuOpen bool to true at the start of the scene

        Time.timeScale = 0f; Time.fixedDeltaTime = 0f;  //Set the timescales to zero (freezes the game)
        AudioListener.pause = true;                     //Pauses dspTime and mutes all audio
    }

    // Update is called once per frame
    void Update()
    {
        if (startMenuOpen && Input.anyKeyDown && !Input.GetKeyDown(KeyCode.Escape))
        {
            StartCoroutine("DisableStartMenu");
        }
    }

    IEnumerator DisableStartMenu()
    {
        textGlow.SetActive(false);                          //Disables text glow
        startPanelAnim.SetBool("StartGame", true);          //Fades out the start menu

        yield return StartCoroutine(CoroutineUtil.WaitForRealSeconds(1f)); //Waits one second in realtime (the game's timescale is currently 0)

        Time.timeScale = 1f; Time.fixedDeltaTime = 0.02f;    //Set the timescales to default (unfreezes the game)
        AudioListener.pause = false;                         //Unpauses dspTime and unmutes all audio
        timerScript.secondsSinceStart = (float)AudioSettings.dspTime;   //Saves the time as a float when the song first starts.

        startMenuOpen = false;       //Set the startMenuOpen bool to false
        startPanel.SetActive(false); //Disable the start panel
        this.enabled = false;        //Disables this script as it'll no longer be used until the scene gets restarted
    }
}
