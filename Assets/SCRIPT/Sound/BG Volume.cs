using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class BGVolume : MonoBehaviour
{
    public AudioSource Vol;

    // Update is called once per frame
    void Update()
    {
        Vol.volume = Datainfo.VolumeBG;
        if (Datainfo.timeRemaining < 30)
        {
            Vol.pitch = 1.5f;
        }
        else
        {
            Vol.pitch = 1f;
        }
    }
}
