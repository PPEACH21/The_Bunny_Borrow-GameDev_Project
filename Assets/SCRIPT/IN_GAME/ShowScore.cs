using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ShowScore : MonoBehaviour
{
    public TMP_Text text;
    void Update()
    {
        text.text= string.Format("{0}",Datainfo.score);
        //Debug.Log(Datainfo.score);
    }
}
