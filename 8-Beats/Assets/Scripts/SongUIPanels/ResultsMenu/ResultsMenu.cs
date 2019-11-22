using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//Enables the ResultsMenu and shows player stats
public class ResultsMenu : MonoBehaviour
{
    public GameObject resultsMenu; //Results menu panel

    [Space]
    public TextMeshProUGUI rankText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highestComboText;

    public TextMeshProUGUI missCountText;
    public TextMeshProUGUI badCountText;
    public TextMeshProUGUI goodCountText;
    public TextMeshProUGUI perfectCountText;

    //ENABLE RESULTS MENU
    public void EnableResultsMenu()
    {
        resultsMenu.SetActive(true); //Enable the menu

        highestComboText.text = ComboTracker.maxCombo.ToString(); //Sets the highestComboText to the max combo
        missCountText.text = ComboTracker.missCount.ToString(); //Sets the missCountText to the miss count

        AudioManager.instance.Play("SongComplete"); //Play the song complete sound
    }
}
