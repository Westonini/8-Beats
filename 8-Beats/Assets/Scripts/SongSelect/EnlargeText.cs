using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnlargeText : MonoBehaviour
{
    private Animator textAnim;

    private void Awake()
    {
        textAnim = GetComponent<Animator>();
    }

    //ENLARGE TEXT WHEN MOUSED OVER
    public void Enlarge()
    {
        textAnim.SetBool("Shrink", false);
        textAnim.SetBool("Enlarge", true);
    }

    //NORMALIZE TEXT WHEN MOUSE LEAVES
    public void Shrink()
    {
        textAnim.SetBool("Shrink", true);
        textAnim.SetBool("Enlarge", false);
    }
}
