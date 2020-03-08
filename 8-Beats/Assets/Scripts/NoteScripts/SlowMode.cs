using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlowMode : MonoBehaviour
{
    public static bool slowModeEnabled = false;
    public GameObject slowModeInfo;

    public Toggle slowModeToggle;
    static bool smToggleBool = false;

    [Space]
    public bool isOnPauseMenu = false;
    public GameObject slowModeRestartInfo;

    //Correctly displays the toggle isOn on the button.
    private void OnEnable()
    {
        slowModeToggle.isOn = smToggleBool;

        //Make sure this text is disabled the next time the scene is loaded
        if (slowModeRestartInfo != null)
           slowModeRestartInfo.SetActive(false);
    }
    private void OnDisable()
    {
        smToggleBool = slowModeToggle.isOn;
    }

    //SLOWMODE ENABLE/DISABLE BUTTON
    public void ToggleSlowMode(bool toggle)
    {
        slowModeEnabled = toggle;

        //If the toggle was set to true and you're in a pause menu within a level, display some text telling the player that a level restart is needed.
        if (isOnPauseMenu && slowModeRestartInfo != null)
            slowModeRestartInfo.SetActive(true);
    }

    //SHOW INFO FOR SLOWMODE WHEN MOUSE ENTERS
    public void OnMouseEnter()
    {
       slowModeInfo.SetActive(true);
    }

    //HIDE INFO FOR SLOWMODE WHEN MOUSE EXITS
    public void OnMouseExit()
    {
        slowModeInfo.SetActive(false);
    }
}
