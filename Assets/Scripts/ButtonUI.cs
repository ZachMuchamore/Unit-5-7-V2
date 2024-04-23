using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


public class ButtonUI : MonoBehaviour
{
    [SerializeField] private string Level1 = "Level1";
    [SerializeField] private string OptionsMenu = "OptionsMenu";
    [SerializeField] private string AudioMenu = "AudioMenu";
    [SerializeField] private string StartMenu = "StartMenu";
    [SerializeField] private string ControlsMenu = "ControlsMenu";
    [SerializeField] private string AccessibilityMenu = "AccessibilityMenu";

    public AudioSource ClickEffect;

    public void PlayButton()
    {
        SceneManager.LoadScene(Level1);
    } 

    public void OptionsButton()
    {
        SceneManager.LoadScene(OptionsMenu);
    }
    public void AudioButton()
    {
        SceneManager.LoadScene(AudioMenu);
    }
    public void OptionsBack()
    {
        SceneManager.LoadScene(StartMenu);
    }
    public void AudioBack()
    {
        SceneManager.LoadScene(OptionsMenu);
    }
    public void ControlsButton()
    {
        SceneManager.LoadScene(ControlsMenu);
    }
    public void AccessibilityButton()
    {
        SceneManager.LoadScene(AccessibilityMenu);
    }
    public void ClickSound()
    {
        ClickEffect.Play();
    }

    public void QuitGame()
    {
        SceneManager.LoadScene(StartMenu);
    }

    public void QuitToWindows()
    {
        Application.Quit();
    }

}
