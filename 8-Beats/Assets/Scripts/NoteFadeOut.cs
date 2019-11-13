using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Fades out and destroys the ntoe gameobject when the note reaches its final endpoint
public class NoteFadeOut : MonoBehaviour
{
    Animator noteAnim;         //The note's animation component

    //This method gets called before the Start() method and is good for getting references
    void Awake()
    {
        //Get the note's components by simply getting the components that are on the same gameobject as this script
        noteAnim = GetComponent<Animator>();
    }

    //FADEOUT+DESTROY NOTE
    public IEnumerator FadeAndDestroy()
    {
        noteAnim.SetBool("FadeOut", true);      //Start the FadeOut animation of the note
        yield return new WaitForSeconds(0.2f);  //Wait 0.2 seconds before doing the following code
        Destroy(gameObject);                    //Destroy this note gameobject
    }
}
