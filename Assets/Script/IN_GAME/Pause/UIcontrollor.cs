using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIcontrollor : MonoBehaviour
{
    public Slider Musicslider, SFXslider;

    public void ToggleMusic()
    {
        AudioManager.instance.ToggleMusic();
    }
    public void ToggleSFX()
    {
        AudioManager.instance.ToggleSFX();
    }
    public void Musicvolume()
    {
        AudioManager.instance.MusicVolume(Musicslider.value);
    }
    public void SFXvolume()
    {
        AudioManager.instance.SFXVolume(SFXslider.value);
    }

}
