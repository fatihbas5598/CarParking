using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MusicMixerControl : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider masterSlider;
    public Slider musicSlider;
    public Slider sfxSlider;

    void SetSliders()
    {
        masterSlider.value = PlayerPrefs.GetFloat("Master Volume");
        musicSlider.value = PlayerPrefs.GetFloat("Music Volume");
        sfxSlider.value = PlayerPrefs.GetFloat("SFX Volume");
    }

    private void Start()
    {
        if(PlayerPrefs.HasKey("Master Volume"))
        {
            mixer.SetFloat("Master Volume", PlayerPrefs.GetFloat("Master Volume"));
            mixer.SetFloat("Music Volume", PlayerPrefs.GetFloat("Music Volume"));
            mixer.SetFloat("SFX Volume", PlayerPrefs.GetFloat("SFX Volume"));

            SetSliders();
        }
        else
        {
            SetSliders();
        }
    }

    public void UpdateMasterVolume()
    {
        mixer.SetFloat("Master Volume", masterSlider.value);
        PlayerPrefs.SetFloat("Master Volume", masterSlider.value);
    }

    public void UpdateMusicVolume()
    {
        mixer.SetFloat("Music Volume", musicSlider.value);
        PlayerPrefs.SetFloat("Music Volume", musicSlider.value);
    }

    public void UpdateSFXVolume()
    {
        mixer.SetFloat("SFX Volume", sfxSlider.value);
        PlayerPrefs.SetFloat("SFX Volume", sfxSlider.value);
    }

    private void Update()
    {
        
    }
}
