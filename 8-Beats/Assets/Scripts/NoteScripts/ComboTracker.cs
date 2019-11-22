using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboTracker : MonoBehaviour
{
    public static int currentCombo;
    public static int maxCombo;
    public static int missCount;

    // Start is called before the first frame update
    void Start()
    {
        currentCombo = 0;
        maxCombo = 0;
        missCount = 0;
    }

    public static void AddToComboCount()
    {
        currentCombo += 1;

        if (currentCombo > maxCombo)
            maxCombo = currentCombo;
    }

    public static void ResetComboCount()
    {
        missCount += 1;
        currentCombo = 0;
    }
}
