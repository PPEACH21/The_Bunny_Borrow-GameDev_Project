using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public SoundFX[] musicSound, sfxSound;
    public AudioSource musicSource, sfxSource;


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

    private void Start()
    {
        PlayMusic("theme");
       
    }
    
    
    public void PlayMusic(string name)
    {
        SoundFX s = Array.Find(musicSound, x => x.name == name);
        if (s == null)
        {
            Debug.Log("Sond not found");
        }
        else
        {
            musicSource.clip = s.clip;
            musicSource.Play();
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
    public void ToggleMusic()
    {
        musicSource.mute= !musicSource.mute;
    }
    public void MusicVolume(float volume)
    {
        musicSource.volume = volume;
    }
    public void SFXVolume(float volume)
    {
        sfxSource.volume = volume;
    }
}
