using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SFXVolume: MonoBehaviour
{
    public AudioSource Vol;

    // Update is called once per frame
    void Update()
    {
        Vol.volume = Datainfo.VolumeSFX;
    }
}
