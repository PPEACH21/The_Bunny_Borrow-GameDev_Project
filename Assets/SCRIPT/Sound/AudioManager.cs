using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public SoundFX[] sfxSound;
    public AudioSource sfxSource;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    
    public void PlaySFX(string name) 
    {
        SoundFX s = Array.Find(sfxSound, x => x.name == name);
        if (s == null)
        {
            Debug.Log("Sond not found");
        }
        else
        {
            sfxSource.PlayOneShot(s.clip);
        }
    }
    public void ToggleSFX()
    {
        sfxSource.mute= !sfxSource.mute;
    }

    public void SFXVolume(float volume)
    {
        sfxSource.volume = volume;
    }
}
