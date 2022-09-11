using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour
{
    public Dropdown resolutionDropDown;
    public Dropdown qualityDropDown;

    Resolution[] resolutions;

    public void Start()
    {
        resolutionDropDown.ClearOptions();
        List<string> options = new List<string>();
        resolutions = Screen.resolutions;
        int currentResolutionIndex = 0;
        
        for(int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height + " " + resolutions[i].refreshRate + "Hz";
            options.Add(option);
            if(resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionDropDown.AddOptions(options);
        resolutionDropDown.RefreshShownValue();
        LoadSettings(currentResolutionIndex);
    }

    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }

    public void SetResolution(int resolutionIndex) 
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void ExitSettings()
    {
        SceneManager.LoadScene(0);
    }

    public void SaveSettings()
    {
        PlayerPrefs.SetInt("QuliteSettingPref", qualityDropDown.value);
        PlayerPrefs.SetInt("ResolutionPref", resolutionDropDown.value);
        PlayerPrefs.SetInt("FullScreenPref", System.Convert.ToInt32(Screen.fullScreen));
    }

    public void LoadSettings(int currentResolutionIndex)
    {
        if (PlayerPrefs.HasKey("QuliteSettingPref"))
        {
            qualityDropDown.value = PlayerPrefs.GetInt("QuliteSettingPref");
        }
        else
        {
            qualityDropDown.value = 3;
        }

        if (PlayerPrefs.HasKey("ResolutionPref"))
        {
            resolutionDropDown.value = PlayerPrefs.GetInt("ResolutionPref");
        }
        else
        {
            resolutionDropDown.value = currentResolutionIndex;
        }

        if (PlayerPrefs.HasKey("FullScreenPref"))
        {
            Screen.fullScreen = System.Convert.ToBoolean(PlayerPrefs.GetInt("FullScreenPref"));
        }
        else
        {
            Screen.fullScreen = true;
        }
    }
}
