using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Changes scenes to the song scene.
public class SongSelect : MonoBehaviour
{
    public string songSceneName; //The name of the selected song's scene
    public string difficulty;    //The difficulty selected

    //SONG SELECT BUTTON
    public void SelectSong()
    {
        DifficultyTracker.difficultyLevel = difficulty; //Set difficultyLevel on DifficultyTracker to whatever the difficulty is

        AudioManager.instance.Stop("MM_Music"); //Stops the main menu music
        SceneManager.LoadScene(songSceneName); //Load the scene of the song
    }
}
