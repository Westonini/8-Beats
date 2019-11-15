using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Temporary note spawner for spawning notes in our Test song
public class TempNoteSpawner : MonoBehaviour
{
    //Spawn Positions
    public Transform topSpawnPos;
    public Transform rightSpawnPos;
    public Transform bottomSpawnPos;
    public Transform leftSpawnPos;

    [Space]
    //Note Prefabs
    public GameObject downwardsNote;
    public GameObject leftwardsNote;
    public GameObject upwardsNote;
    public GameObject rightwardsNote;

    [Space]
    //Button GameObjects
    public GameObject topButton;
    public GameObject rightButton;
    public GameObject bottomButton;
    public GameObject leftButton;

    private int beatsPassed;  //How many beats have passed
    public int firstBeatOffset = 2; //Offset for starting beat
    
    void Start()
    {
        //Loops 10 times
        for (int i = 0; i <= 10; i++)
        {
            //Instantiate one note in each direction by calling the InstantiateNote() function
            InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 6);
            InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 8);
            InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 10);
            InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 12);

            //Add 8 to beatsPassed
            beatsPassed += 8;
        }
    }

    private void InstantiateNote(string noteName, GameObject notePrefab, Transform spawnPos, GameObject buttonPos, int startingBeat)
    {
        //Create a new gameobject to be our instantiated gameobject
        GameObject instantiatedNote;
        
        //Instantiate the note using the note's prefab and spawn position. Cast it as a GameObject so we can modify its properties.
        instantiatedNote = Instantiate(notePrefab, spawnPos.position, spawnPos.rotation) as GameObject;
        instantiatedNote.name = noteName; //Change the gameobject's name
        instantiatedNote.transform.SetParent(this.gameObject.transform); //Change the gameobject's parent gameobject

        //Get the NoteScroller script from the instantiated object so we can modify the its values
        NoteScroller ns;
        ns = instantiatedNote.GetComponent<NoteScroller>();
        ns.spawnPos = spawnPos.gameObject; //Set the spawn point
        ns.buttonPos = buttonPos; //Set the button position
        ns.beatOfNote = startingBeat + beatsPassed + firstBeatOffset; //Set the beatOfNote
    }
}
