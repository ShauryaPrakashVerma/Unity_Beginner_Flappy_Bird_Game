using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class soundControl : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider;
    void Start()
    {
        if(PlayerPrefs.HasKey("Volume"))
        {
            Load();
        }
        else
        {
            volumeSlider.value = 1f;
            Save();
        }
        ChangeVolume();
    }
    
    // sets the volume to the value of the slider
    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }

    // save the player prefs for the volume
    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("Volume");
    }
   

    private void Save()
    {
        PlayerPrefs.SetFloat("Volume", volumeSlider.value);
        PlayerPrefs.Save();
    }
}
