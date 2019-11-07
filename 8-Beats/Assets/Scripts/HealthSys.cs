using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Manages the player's health
public class HealthSys : MonoBehaviour
{
    public static int health = 100; //The player's health

    // Start is called before the first frame update
    void Start()
    {
        health = 100; //Reset health to 100 when scene starts/restarts
    }

    //DECREASE CURRENT HEALTH
    public static void Damage(int damageAmount = 7)
    {
        //If the player's current health is above 0..
        if (health > 0)
        {
            health -= damageAmount; //Decrease health by the damageAmount value
        }

        Debug.Log("HEALTH DECREASED. Current Health: " + health); //Shows the current health in the console.
    }
}
