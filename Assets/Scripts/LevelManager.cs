using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using static UnityEngine.Rendering.DebugUI;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    [SerializeField] AudioMixer audioMixer;

    public const string MUSIC_KEY = "MusicVolume";
    public const string SFX_KEY = "SFXVolume";


    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            print("dont destroy");

        }
        else
        {
            print("do destroy");
            Destroy(gameObject);
        }
        LoadVolume();


    }
    public void LoadVolume()
    {
        float MusicVolume = PlayerPrefs.GetFloat(MUSIC_KEY, 1.0f);
        float SFXVolume = PlayerPrefs.GetFloat(SFX_KEY, 1.0f);

        audioMixer.SetFloat(AudioManager.MIXER_MUSIC, Mathf.Log10(MusicVolume) * 20);
        audioMixer.SetFloat(AudioManager.MIXER_SFX, Mathf.Log10(SFXVolume) * 20);

    }
}
