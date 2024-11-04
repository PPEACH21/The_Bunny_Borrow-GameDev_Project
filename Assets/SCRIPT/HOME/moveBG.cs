using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBG : MonoBehaviour
{
    public RectTransform BG;
    private float speedBG = 10f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.back * speedBG * Time.deltaTime);
        transform.Translate(Vector3.up * speedBG * Time.deltaTime);
        if (BG.anchoredPosition.y > -811)
        {
            BG.anchoredPosition = new Vector2(-691, -1384);
        }
    }
}
