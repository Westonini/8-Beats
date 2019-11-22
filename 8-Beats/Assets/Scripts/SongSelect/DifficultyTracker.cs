using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Used to select the correct difficulty of the song during the song's scene
public class DifficultyTracker : MonoBehaviour
{
    public static string difficultyLevel;

    public static DifficultyTracker instance;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
