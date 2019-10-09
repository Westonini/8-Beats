using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Changes scenes to the song scene.
public class SongSelect : MonoBehaviour
{
    public string songSceneName; //The name of the selected song's scene

    //SONG SELECT BUTTON
    public void SelectSong()
    {
        SceneManager.LoadScene(songSceneName); //Load the scene of the song
    }
}
