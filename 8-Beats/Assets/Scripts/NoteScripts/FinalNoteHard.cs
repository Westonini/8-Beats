using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Temporary note spawner for spawning notes in our Test song
public class FinalNoteHard : MonoBehaviour
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
    //Note Prefabs for Doubles
    public GameObject downDouble;
    public GameObject upDouble;
    public GameObject leftDouble;
    public GameObject rightDouble;

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
        /* Friendly Reminder: Only Use Quarter & Eighth Notes for First Level! Make it easier!
           BPM = 110 for First Tune's Midi
           Hey guys, thanks for all of your help with coding this program! Anyways, here's a 
           quick guide for most of my comments throughout this part of the code:

           1. A portion of code under "One Bar" refers to the instantiated notes that will spawn
              in the span of four seconds. Usually, it would be four instantiated notes in four
              seconds, or in other words, one note spawned per second. Other bars such as 
              "Two / Three / Four / Last" bars just refer to order, that's all.

           2. I like to refer to these one-second spawned notes as "quarter" or normal notes, since technically
              they're a quarter of a single bar in code. Usually, the double value at the end of the
              InstantiateNote() instance is added with a value of one to create another quarter note.

           3. If you want to add a quicker note such as an "eighth" note, all you have to do is add a value of
              one half to the previous value of the InstantiateNote() object and use the new, added value
              for your next InstantiateNote() instance. 

           4. The only portions of the code that needs to be completed is the Pretty Epic Intrumental Arc 
              & the Final Main Title Refrain Arc.
              Most of these parts are ver similar to their previous versions earlier in the code, by the way.
              The only new parts that need to be created are the Pretty Epic Instrumental Arc.

           5. Also you may notice that for the mentioned previous parts, I managed to comment the start times of
              each single bar that happens in sync with the music. You're more than welcome to change the kind of 
              InstantiateNote() object that'll be created, just don't forget when it usually starts to sync it back
              to the music.

           Anyways, thank you so much for your help, you guys! I gotta catch up with other assignments for the 
           meantime, but I'll be back later to help finish this once and for all!          
         */



        /* Vocal Introduction:  Beats starting / landing on press @ 4.5 -> Instantiate Note @ 2.5*/
        // Whole Portion is treated twice as slow for suspense; One Bar
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 2.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 5.3);
        // One Bar
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 9.25);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 12.5);
        // One Bar
        InstantiateNote("DownScrollingNote", downDouble, topSpawnPos, topButton, 16.25);
        InstantiateNote("UpScrollingNote", upDouble, bottomSpawnPos, bottomButton, 16.25);
        InstantiateNote("LeftScrollingNote", leftDouble, rightSpawnPos, rightButton, 19);
        InstantiateNote("RightScrollingNote", rightDouble, leftSpawnPos, leftButton, 19);
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
        // One Bar
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


        /* First Vocal Chorus Arc:  Beats starting / landing on press @ 70.5 Seconds -> Instantiate Note @ 68.5 */
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


        /* First Intro Vocal Echo:  Beats starting / landing on press @ 102.5 Seconds -> Instantiate Note @ 100.5 */
        // One Bar
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 100.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 101.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 102.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 103.5);
        // One Bar - Double
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 104.5);
        InstantiateNote("LeftScrollingNote", leftDouble, rightSpawnPos, rightButton, 105.5);
        InstantiateNote("RightScrollingNote", rightDouble, leftSpawnPos, leftButton, 105.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 106.5);
        InstantiateNote("LeftScrollingNote", leftDouble, rightSpawnPos, rightButton, 107.5);
        InstantiateNote("RightScrollingNote", rightDouble, leftSpawnPos, leftButton, 107.5);
        // One Bar
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 108.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 109.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 110.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 111.5);
        // One Bar - Double
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 112.5);
        InstantiateNote("LeftScrollingNote", leftDouble, rightSpawnPos, rightButton, 113.5);
        InstantiateNote("RightScrollingNote", rightDouble, leftSpawnPos, leftButton, 113.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 114.5);
        InstantiateNote("LeftScrollingNote", leftDouble, rightSpawnPos, rightButton, 115.5);
        InstantiateNote("RightScrollingNote", rightDouble, leftSpawnPos, leftButton, 115.5);

        /* First Main Title Refrain Arc:  Beats starting / landing on press @ 118.5 Seconds -> Instantiate Note @ 116.5 */
        // One Bar
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 116.5);
        InstantiateNote("DownScrollingNote", downDouble, topSpawnPos, topButton, 117.5);
        InstantiateNote("UpScrollingNote", upDouble, bottomSpawnPos, bottomButton, 117.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 118.5);
        InstantiateNote("DownScrollingNote", downDouble, topSpawnPos, topButton, 119.5);
        InstantiateNote("UpScrollingNote", upDouble, bottomSpawnPos, bottomButton, 119.5);
        // One Bar
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 120.5);
        InstantiateNote("DownScrollingNote", downDouble, topSpawnPos, topButton, 121.5);
        InstantiateNote("UpScrollingNote", upDouble, bottomSpawnPos, bottomButton, 121.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 122.5);
        InstantiateNote("DownScrollingNote", downDouble, topSpawnPos, topButton, 123.5);
        InstantiateNote("UpScrollingNote", upDouble, bottomSpawnPos, bottomButton, 123.5);
        // One Bar
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 124.5);
        InstantiateNote("DownScrollingNote", downDouble, topSpawnPos, topButton, 125.5);
        InstantiateNote("LeftScrollingNote", leftDouble, rightSpawnPos, rightButton, 125.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 126.5);
        InstantiateNote("UpScrollingNote", upDouble, bottomSpawnPos, bottomButton, 127.5);
        InstantiateNote("RightScrollingNote", rightDouble, leftSpawnPos, leftButton, 127.5);
        // One Bar
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 128.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 129.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 130.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 131.5);
        // Two Bar
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 132.5);
        InstantiateNote("DownScrollingNote", downDouble, topSpawnPos, topButton, 133.5);
        InstantiateNote("UpScrollingNote", upDouble, bottomSpawnPos, bottomButton, 133.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 134.5);
        InstantiateNote("DownScrollingNote", downDouble, topSpawnPos, topButton, 135.5);
        InstantiateNote("UpScrollingNote", upDouble, bottomSpawnPos, bottomButton, 135.5);
        // Two Bar
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 136.5);
        InstantiateNote("DownScrollingNote", downDouble, topSpawnPos, topButton, 137.5);
        InstantiateNote("UpScrollingNote", upDouble, bottomSpawnPos, bottomButton, 137.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 138.5);
        InstantiateNote("DownScrollingNote", downDouble, topSpawnPos, topButton, 139.5);
        InstantiateNote("UpScrollingNote", upDouble, bottomSpawnPos, bottomButton, 139.5);
        // Two Bar
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 140.5);
        InstantiateNote("DownScrollingNote", downDouble, topSpawnPos, topButton, 141.5);
        InstantiateNote("LeftScrollingNote", leftDouble, rightSpawnPos, rightButton, 141.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 142.5);
        InstantiateNote("UpScrollingNote", upDouble, bottomSpawnPos, bottomButton, 143.5);
        InstantiateNote("RightScrollingNote", rightDouble, leftSpawnPos, leftButton, 143.5);
        // Two Bar
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 144.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 145.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 146.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 147.5);


        /* Second Instrum Arc:  Beats starting / landing on press @ 150.5 Seconds -> Instantiate Note @ 148.5 */
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


        /* Second Vocal Chorus Arc:  Beats starting / landing on press @ 166.5 Seconds -> Instantiate Note @ 164.5 */
        // One Bar for Settling into Chorus Arc
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 164.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 165.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 166.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 167.5);
        // One Bar - Intensive
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 168.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 169.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 170);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 170.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 171.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 172);
        // Two Bar - Settle
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 172.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 173.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 174.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 175.5);
        // Two Bar - Intensive
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 176.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 177.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 178);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 178.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 179.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 180);
        // Three Bar - Settle
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 180.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 181.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 182.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 183.5);
        // Three Bar - Intensive
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 184.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 185.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 186);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 186.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 187.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 188);
        // Four Bar - Settle
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 188.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 189.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 190.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 191.5);

        // Four Bar - Intensive
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 192.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 193.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 194);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 194.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 195.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 196);

        /* Second Intro Vocal Echo:  Beats starting / landing on press @ 198.5 Seconds -> Instantiate Note @ 196.5 */
        // One Bar 
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 196.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 197.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 198.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 199.5);
        // One Bar - Double
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 196.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 197.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 197.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 198.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 199.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 199.5);
        // One Bar 
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 200.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 201.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 202.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 203.5);
        // One Bar - Double
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 204.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 205.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 205.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 206.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 207.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 207.5);
        // One Bar - Extra Ba-Dums
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 208.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 209.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 210.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 211.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 212);


        /* Second Main Title Refrain Arc:  Beats starting / landing on press @ 214.5 Seconds -> Instantiate Note @ 212.5 */
        // One Bar
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 212.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 213.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 213.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 214.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 215.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 215.5);
        // One Bar
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 216.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 217.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 217.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 218.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 219.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 219.5);
        // One Bar
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 220.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 221.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 221.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 222.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 223.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 223.5);
        // One Bar
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 224.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 225.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 226.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 227.5);
        // Two Bar
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 228.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 229.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 229.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 230.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 231.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 231.5);
        // Two Bar
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 232.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 233.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 233.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 234.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 235.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 235.5);
        // Two Bar
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 236.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 237.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 237.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 238.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 239.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 239.5);
        // Two Bar
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 240.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 241.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 242.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 243.5);


        /* Third Instrum Arc:  Beats starting / landing on press @ 246.5 Seconds -> Instantiate Note @ 244.5 */
        // One Bar - Settle 
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 244.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 245.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 246.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 247.5);
        // One Bar - Intensive
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 248.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 249.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 250.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 250.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 251.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 251.5);
        // Two Bar - Settle
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 252.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 253.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 254.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 255.5);
        // Two Bar - Intensive
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 256.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 257.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 258.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 258.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 259.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 259.5);


        /* Pretty Epic Intrumental Arc:  Beats starting / landing on press @ 262.5 Seconds -> Instantiate Note @ 260.5 */
        // One Bar Start @ 260.5
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 260.5);
        // One Bar Start @ 264.5
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 264.5);
        // One Bar Start @ 268.5
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 268.5);
        // One Bar Start @ 272.5
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 272.5);
        // Two Bar Start @ 276.5
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 276.5);
        // Two Bar Start @ 280.5
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 280.5);
        // Two Bar Start @ 284.5
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 284.5);
        // Two Bar Start @ 288.5
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 288.5);


        /* Final Intro Vocal Echo:  Beats starting / landing on press @ 294.5 Seconds -> Instantiate Note @ 292.5 */
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 292.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 293.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 294.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 295.5);
        // One Bar - Double
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 296.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 297.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 297.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 298.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 299.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 299.5);
        // One Bar
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 300.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 301.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 302.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 303.5);
        // One Bar - Double
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 304.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 305.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 305.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 306.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 307.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 307.5);


        /* Final Main Title Refrain Arc:  Beats starting / landing on press @ 310.5 Seconds -> Instantiate Note @ 308.5 */
        // One Bar Start @ 308.5
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 308.5);
        // One Bar Start @ 312.5
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 312.5);
        // One Bar Start @ 316.5
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 316.5);
        // One Bar Start @ 320.5
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 320.5);
        // Two Bar Start @ 324.5
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 324.5);
        // Two Bar Start @ 328.5
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 328.5);
        // Two Bar Start @ 332.5
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 332.5);
        // Two Bar Start @ 336.5
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 336.5);


        /* Final Instrum Arc:  Beats starting / landing on press @ 342.5 Seconds -> Instantiate Note @ 340.5 */
        // One Bar Start @ 340.5
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 340.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 341.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 342.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 343.5);
        // One Bar Start @ 344.5
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 344.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 345.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 346.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 347.5);
        // One Bar Start @ 348.5
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 348.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 349.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 350.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 351.5);
        // One Bar Start @ 352.5
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 352.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 353.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 354.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 355);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 355.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 356);
        // Two Bar Start @ 356.5
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 356.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 357.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 358.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 359.5);
        // Two Bar Start @ 360.5
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 360.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 361.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 362.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 363.5);
        // Two Bar Start @ 364.5
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 364.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 365.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 366.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 367.5);
        // Two Bar Start @ 368.5
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 368.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 369.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 370.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 371);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 371.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 372);



        /* Gradual Instrum End:  Beats starting / landing on press @ 374.5 Seconds -> Instantiate Note @ 372.5 */
        // Last Bar Start @ 372.5
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 372.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 373.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 374.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 375.5);
        // Last Bar Start @ 376.5 ( 3 & 4 & )
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 376.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 377.5);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 378.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 379);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 379.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 380);
        // Last Bar Start @ 380.5
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 380.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 381.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 382.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 383.5);
        // Last Bar Start @ 384.5 ( 3 & 4 & )
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 384.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 385.5);
        InstantiateNote("DownScrollingNote", downwardsNote, topSpawnPos, topButton, 386.5);
        InstantiateNote("RightScrollingNote", rightwardsNote, leftSpawnPos, leftButton, 387);
        InstantiateNote("UpScrollingNote", upwardsNote, bottomSpawnPos, bottomButton, 387.5);
        InstantiateNote("LeftScrollingNote", leftwardsNote, rightSpawnPos, rightButton, 388);


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
