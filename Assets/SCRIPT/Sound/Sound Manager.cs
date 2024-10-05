using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SoundManager : MonoBehaviour
{
    public Slider sliderBG;
    public Slider sliderSFX;


    private void Start()
    {
        sliderBG.value = Datainfo.VolumeBG;
        sliderSFX.value = Datainfo.VolumeSFX;
    }
    // Update is called once per frame
    void Update()
    {
        Datainfo.VolumeBG = sliderBG.value;
        Datainfo.VolumeSFX = sliderSFX.value;
        //Debug.Log(Datainfo.VolumeBG);
        //Debug.Log(Datainfo.VolumeSFX);
    }
}
