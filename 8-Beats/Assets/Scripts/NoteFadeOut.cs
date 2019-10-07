using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Fades out and destroys the ntoe gameobject when the note reaches its final endpoint
public class NoteFadeOut : MonoBehaviour
{
    Animator noteAnim;         //The note's animation component
    NoteScroller noteScroller; //The note's NoteScroller script

    //This method gets called before the Start() method and is good for getting references
    void Awake()
    {
        //Get the note's components by simply getting the components that are on the same gameobject as this script
        noteAnim = GetComponent<Animator>();
        noteScroller = GetComponent<NoteScroller>();
    }

    //Subscribe/Unsubscribe to _noteReachedDestination to call FadeHandeler() whenever _noteReachedDestination gets called.
    //Gets called when this gameobject is enabled
    private void OnEnable()
    {
        noteScroller._noteReachedDestination += FadeHandeler;
    }
    //Gets called when this gameobject is disabled
    private void OnDisable()
    {
        noteScroller._noteReachedDestination -= FadeHandeler;
    }

    //Starts the FadeAndDestroy coroutine
    void FadeHandeler()
    {
        StartCoroutine("FadeAndDestroy");
    }

    //FADEOUT+DESTROY NOTE
    IEnumerator FadeAndDestroy()
    {
        noteAnim.SetBool("FadeOut", true);      //Start the FadeOut animation of the note
        yield return new WaitForSeconds(0.2f);  //Wait 0.2 seconds before doing the following code
        Destroy(gameObject);                    //Destroy this note gameobject
    }
}
