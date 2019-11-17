using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Enables the ResultsMenu and shows player stats
public class ResultsMenu : MonoBehaviour
{
    public GameObject resultsMenu; //Results menu panel

    //ENABLE RESULTS MENU
    public void EnableResultsMenu()
    {
        resultsMenu.SetActive(true); //Enable the menu
        AudioManager.instance.Play("SongComplete"); //Play the song complete sound
    }
}
