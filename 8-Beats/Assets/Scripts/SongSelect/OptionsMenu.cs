using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

//Options menu that consists of various changable settings
public class OptionsMenu : MonoBehaviour
{
    public AudioMixer mixerChannel;

    [Space]
    public TextMeshProUGUI musicVolText;
    public TextMeshProUGUI effectsVolText;
    public TextMeshProUGUI uiVolText;

    [Space]
    public Slider musicVolSlider;
    public Slider effectsVolSlider;
    public Slider uiVolSlider;
    public Toggle fullscreenToggle;
    public TMP_Dropdown resolutionDropdown;

    static float musicVol;
    static float effectsVol;
    static float uiVol;
    static bool fsToggleBool = true;
    static int resolutionValue;

    private Resolution[] resolutions;

    private void Start()
    {
        resolutions = Screen.resolutions;
        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height + " " + resolutions[i].refreshRate + "Hz";
            options.Add(option);

            if (resolutions[i].width == Screen.width && resolutions[i].height == Screen.height && resolutions[i].refreshRate == Screen.currentResolution.refreshRate)
            {
                currentResolutionIndex = i;
            }
        }
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();

        //Set the resolution value integer to what it was last changed to
        //resolutionDropdown.value = resolutionValue;
    }

    //WHEN OPTIONS MENU IS ENABLED
    private void OnEnable()
    {
        //Set the volume percentage texts to what they were last changed to.
        musicVolText.text = (int)(Mathf.InverseLerp(-60, 0, Mathf.RoundToInt(musicVol)) * 100) + "%";
        effectsVolText.text = (int)(Mathf.InverseLerp(-50, 0, Mathf.RoundToInt(effectsVol)) * 100) + "%";
        uiVolText.text = (int)(Mathf.InverseLerp(-50, 0, Mathf.RoundToInt(effectsVol)) * 100) + "%";

        //Set the slider values (slider position) to what they were last changed to.
        musicVolSlider.value = musicVol;
        effectsVolSlider.value = effectsVol;
        uiVolSlider.value = uiVol;

        //Set the fullscreen toggle bool to what it was last changed to
        fullscreenToggle.isOn = fsToggleBool;
    }

    //WHEN OPTIONS MENU IS DISABLED
    private void OnDisable()
    {
        //Save the current volumes
        musicVol = GetMixerVolume("musicVolume");
        effectsVol = GetMixerVolume("effectsVolume");
        uiVol = GetMixerVolume("uiVolume");

        //Save the fullscreen toggle boolean
        fsToggleBool = fullscreenToggle.isOn;

        //Save the resolution value integer
        resolutionValue = resolutionDropdown.value;
    }

    //SETS MUSIC VOLUME
    public void SetMusicVolume(float volume)
    {
        musicVolText.text = (int)(Mathf.InverseLerp(-60, 0, Mathf.RoundToInt(volume)) * 100) + "%"; //Displays and/or updates the music volume in percentage

        if (volume == -60) //If the volume is set to -60, which is the min value on the slider
        {
            mixerChannel.SetFloat("musicVolume", -80); //Adjusts the musicVolume parameter to the lowest number in the mixer.
        }
        else
        {
            mixerChannel.SetFloat("musicVolume", volume); //Adjusts the musicVolume parameter in the mixer.
        }
    }

    //SETS EFFECTS VOLUME
    public void SetEffectsVolume(float volume)
    {
        effectsVolText.text = (int)(Mathf.InverseLerp(-50, 0, Mathf.RoundToInt(volume)) * 100) + "%"; //Displays and/or updates the effects volume in percentage

        if (volume == -50) //If the volume is set to -60, which is the min value on the slider
        {
            mixerChannel.SetFloat("effectsVolume", -80); //Adjusts the effectsVolume parameter to the lowest number in the mixer.
        }
        else
        {
            mixerChannel.SetFloat("effectsVolume", volume); //Adjusts the effectsVolume parameter in the mixer.
        }
    }

    //SETS EFFECTS VOLUME
    public void SetUIVolume(float volume)
    {
        uiVolText.text = (int)(Mathf.InverseLerp(-50, 0, Mathf.RoundToInt(volume)) * 100) + "%"; //Displays and/or updates the UI volume in percentage

        if (volume == -50) //If the volume is set to -60, which is the min value on the slider
        {
            mixerChannel.SetFloat("uiVolume", -80); //Adjusts the uiVolume parameter to the lowest number in the mixer.
        }
        else
        {
            mixerChannel.SetFloat("uiVolume", volume); //Adjusts the uiVolume parameter in the mixer.
        }
    }

    //GETS MIXER CHANNEL VOLUMES
    public float GetMixerVolume(string mixerParameter)
    {
        float value;
        bool result = mixerChannel.GetFloat(mixerParameter, out value);
        if (result)
           return value;
        else
            return 0f;
    }

    //FULLSCREEN ENABLE/DISABLE
    public void SetFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    //SETS THE RESOLUTION DIMENSIONS
    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];

        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen, resolution.refreshRate);
    }
}
