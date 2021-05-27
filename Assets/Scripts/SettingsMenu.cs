using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    //adjust audio volume
    public AudioMixer audioMixer;
    public void SetVolume (float volume)
    {
        //debug to show that slider is working even without audio
        //Debug.Log(volume);
        audioMixer.SetFloat("Volume", volume);
    }

    //Quality setting
    public void SetQuality(int i)
    {
        QualitySettings.SetQualityLevel(i);
    }

}
