using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DifficultySelect : MonoBehaviour
{
    public GameObject easyDifficulty;
    public GameObject normalDifficulty;
    public GameObject hardDifficulty;
    public GameObject expertDifficulty;

    [Space]
    public string songName;
    public TextMeshProUGUI songInfoText;

    // Start is called before the first frame update
    void Awake()
    {
        if (easyDifficulty != null && DifficultyTracker.difficultyLevel == "Easy")         //If the difficulty was selected to be easy, enable the easy difficulty script
        {
            easyDifficulty.SetActive(true);
            songInfoText.text = songName + "\n\n" + "EASY";
        }
        if (normalDifficulty != null && DifficultyTracker.difficultyLevel == "Normal")     //If the difficulty was selected to be normal, enable the normal difficulty script
        {
            normalDifficulty.SetActive(true);
            songInfoText.text = songName + "\n\n" + "NORMAL";
        }
        if (hardDifficulty != null && DifficultyTracker.difficultyLevel == "Hard")         //If the difficulty was selected to be hard, enable the hard difficulty script
        {
            hardDifficulty.SetActive(true);
            songInfoText.text = songName + "\n\n" + "HARD";
        }
        if (expertDifficulty != null && DifficultyTracker.difficultyLevel == "Expert")    //If the difficulty was selected to be expert, enable the expert difficulty script
        {
            expertDifficulty.SetActive(true);
            songInfoText.text = songName + "\n\n" + "EXPERT";
        }


        if (DifficultyTracker.difficultyLevel == null)                                    //If the difficulty is equal to null, set it to normal (for testing purposes)
        {
            normalDifficulty.SetActive(true);
            songInfoText.text = songName + "\n\n" + "NORMAL";
        }
    }
}
