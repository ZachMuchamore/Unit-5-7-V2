using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public const string MIXER_MUSIC = "MusicVolume";
    public const string MASTER_MUSIC = "MasterVolume";
    public const string MIXER_SFX = "SFXVolume";

    [SerializeField] AudioMixer audioMixer;
    [SerializeField] Slider MusicSlider;
    [SerializeField] Slider MasterSlider;
    [SerializeField] Slider SFXSlider;


    public AudioSource ClickEffect;

    public void Start()
    {
        MusicSlider.value = PlayerPrefs.GetFloat(LevelManager.MUSIC_KEY, 1f);
        SFXSlider.value = PlayerPrefs.GetFloat(LevelManager.SFX_KEY, 1f);
        MasterSlider.value = PlayerPrefs.GetFloat(LevelManager.MASTER_KEY, 1f);

    }

    public void OnDisable()
    {
        PlayerPrefs.SetFloat(LevelManager.MUSIC_KEY, MusicSlider.value);
        PlayerPrefs.SetFloat(LevelManager.MASTER_KEY, MasterSlider.value);
        PlayerPrefs.SetFloat(LevelManager.SFX_KEY, SFXSlider.value);

    }
    public void SetVolume(float Value)
    {
        audioMixer.SetFloat("MasterVolume", Mathf.Log10(Value) * 20);
        print("setting master volume to " + Value);
        print("audio mixer=" + audioMixer);

    }
    public void SetSFX(float Value)
    {
        audioMixer.SetFloat("SFXVolume", Mathf.Log10(Value) * 20);

    }
    public void SetMusic(float Value)
    {
        audioMixer.SetFloat("MusicVolume", Mathf.Log10(Value) * 20);
    }

    public void SetMaster(float Value)
    {
        audioMixer.SetFloat("MasterVolume", Mathf.Log10(Value) * 20);
    }

    public void ClickSound()
    {
        //ClickEffect.Play();

    }
}
