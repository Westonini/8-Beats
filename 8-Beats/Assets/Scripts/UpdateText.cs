using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateText : MonoBehaviour
{
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI comboText;

    void OnEnable()
    {
        NoteScroller._noteReachedDestination += UpdateHealthText;
        NoteScroller._noteReachedDestination += UpdateComboText;
        NoteDetector._noteHit += UpdateComboText;
    }


    void OnDisable()
    {
        NoteScroller._noteReachedDestination -= UpdateHealthText;
        NoteScroller._noteReachedDestination -= UpdateComboText;
        NoteDetector._noteHit -= UpdateComboText;
    }


    void UpdateHealthText()
    {
        healthText.text = "HP: " + HealthSys.health.ToString();
    }

    void UpdateComboText()
    {
        comboText.text = ComboTracker.currentCombo.ToString() + "x";
    }
}
