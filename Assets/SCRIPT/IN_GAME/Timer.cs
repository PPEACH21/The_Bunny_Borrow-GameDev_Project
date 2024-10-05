using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text Timetext;
    string keeptime;
    void Update()
    {
        if(PauseMenu.checkRE == true)
        {
            Datainfo.timeRemaining = Datainfo.timeDafault;
            PauseMenu.checkRE = false;
        }
        if (Datainfo.timeRemaining > 1 && PauseMenu.check == false)
        {
            Datainfo.timeRemaining -= Time.deltaTime;
            Displaytime(Datainfo.timeRemaining);
        }
    }


    void Displaytime(float timetodisplay)
    {
        float mins = Mathf.FloorToInt(timetodisplay / 60);
        float secc = Mathf.FloorToInt(timetodisplay % 60);
        keeptime = string.Format("{0:00}:{1:00}", mins, secc);
        Timetext.text = keeptime;
    }
}
