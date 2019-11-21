using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Temporary note spawner for spawning notes in our Test song
public class FinalNoteSpawner : MonoBehaviour
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
    public int firstBeatOffset = 2; //Offset for starting beat; keep this the same

    void Start()
    {
        //Loops 10 times
        /* References for 120bpm:
         * - 4 Seconds = Whole Note
         * - 2 Seconds = Half Note
         * - 1 Second = Quarter Note
         * - 0.5 Seconds = Eighth Note
         */

        /* Friendly Reminder: Only Use Quarter & Eighth Notes for First Level! Make it easier!
           BPM = 110 for First Tune's Midi
           ( 1.000 ) Quarter note = 60 / BPM              ->      96
           ( 2.000 ) Half note = 120 / BPM                ->      192
           ( 0.500 ) Eighth note = 30 / BPM               ->      48
           ( 0.250 ) Sixteenth note = 15 / BPM            ->      24
           ( 1.500 ) Dotted-quarter note = 90 / BPM       ->      144
           ( 0.750 ) Dotted-eighth note = 45 / BPM        ->      72
           ( 0.375 ) Dotted-sixteenth note = 22.5 / BPM   ->      36
           ( 0.667 ) Triplet-quarter note = 40 / BPM      ->      64
           ( 0.333 ) Triplet-eighth note = 20 / BPM       ->      32
           ( 0.165 ) Triplet-sixteenth note = 10 / BPM    ->      16
         */

        /* Vocal Introduction:  Beats starting / landing on press @ -> Instantiate Note @ */
        // Whole Portion is treated twice as slow for suspense; One Bar
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 2.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 5.5);
        // One Bar
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 9.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 12.5);
        // One Bar
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 16.25);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 16.25);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 19.25);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 19.25);
        // One Bar
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 22.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 24.5);
        // One Bar
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 26.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 28.5);


        /* First Instrum Arc:  Beats starting / landing on press @ 38.5 Seconds -> Instantiate Note @ 36.5 */
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 36.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 37.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 38.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 39.5);
        // One Bar
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 40.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 41.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 42.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 43.5);
        // One Bar
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 44.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 45.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 46.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 47.5);
        // One Bar
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 48.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 49.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 50.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 51);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 51.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 52);
        // Landing Note for One Bar
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 52.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 53.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 54.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 55.5);
        // One Bar
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 56.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 57.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 58.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 59.5);
        // One Bar
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 60.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 61.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 62.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 63.5);
        // One Bar
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 64.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 65.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 66.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 67);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 67.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 68);


        /* First Vocal Chorus Arc:  Beats starting / landing on press @ 54.5 Seconds -> Instantiate Note @ 52.5 */
        // One Bar for Settling into Chorus Arc
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 68.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 69.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 70.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 71.5);
        // One Bar - Intensive
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 72.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 73.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 74);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 74.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 75.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 76);
        // Two Bar - Settle
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 76.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 77.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 78.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 79.5);
        // Two Bar - Intensive
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 80.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 81.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 82);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 82.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 83.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 84);
        // Three Bar - Settle
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 84.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 85.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 86.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 87.5);
        // Three Bar - Intensive
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 88.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 89.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 90);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 90.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 91.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 92);
        // Four Bar - Settle
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 92.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 93.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 94.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 95.5);
        // Four Bar - Intensive
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 96.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 97.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 98);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 98.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 99.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 100);


        /* First Intro Vocal Echo:  Beats starting / landing on press @ Seconds -> Instantiate Note @ */
        // One Bar
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 100.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 101.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 102.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 103.5);
        // One Bar - Double
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 104.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 105.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 105.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 106.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 107.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 107.5);
        // One Bar
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 108.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 109.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 110.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 111.5);
        // One Bar - Double
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 112.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 113.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 113.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton,  114.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 115.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 115.5);

        /* First Main Title Refrain Arc:  Beats starting / landing on press @ Seconds -> Instantiate Note @ */
        // One Bar
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 116.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 117.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 117.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 118.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 119.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 119.5);
        // One Bar
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 120.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 121.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 121.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 122.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 123.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 123.5);
        // One Bar
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 124.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 125.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 125.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 126.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 127.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 127.5);
        // One Bar
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 128.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 129.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 130.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 131.5);
        // Two Bar
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 132.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 133.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 133.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 134.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 135.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 135.5);
        // Two Bar
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 136.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 137.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 137.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 138.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 139.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 139.5);
        // Two Bar
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 140.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 141.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 141.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 142.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 143.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 143.5);
        // Two Bar
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 144.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 145.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 146.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 147.5);


        /* Second Instrum Arc:  Beats starting / landing on press @ 38.5 Seconds -> Instantiate Note @ 36.5 */
        // One Bar - Settle
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 148.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 149.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 150.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 151.5);
        // One Bar - Intensive
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 152.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 153.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 154.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 154.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 155.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 155.5);
        // Two Bar - Settle
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 156.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 157.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 158.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 159.5);
        // Two Bar - Intensive
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 160.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 161.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 162.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 162.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 163.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 163.5);


        /* Second Vocal Chorus Arc:  Beats starting / landing on press @ Seconds -> Instantiate Note @ */
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 164.5);

        /* Second Intro Vocal Echo:  Beats starting / landing on press @ Seconds -> Instantiate Note @ */

        /* Second Main Title Refrain Arc:  Beats starting / landing on press @ Seconds -> Instantiate Note @ */

        /* Pretty Epic Intrumental Arc:  Beats starting / landing on press @ Seconds -> Instantiate Note @ */

        /* Final Intro Vocal Echo:  Beats starting / landing on press @ Seconds -> Instantiate Note @ */

        /* Final Main Title Refrain Arc:  Beats starting / landing on press @ Seconds -> Instantiate Note @ */

        /* Final Instrum Arc:  Beats starting / landing on press @ Seconds -> Instantiate Note @ */


    }

    private void InstantiateNote(string noteName, GameObject notePrefab, Transform spawnPos, GameObject buttonPos, double startingBeat)
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
        ns.beatOfNote = (float) startingBeat + beatsPassed + firstBeatOffset; //Set the beatOfNote
    }
}
