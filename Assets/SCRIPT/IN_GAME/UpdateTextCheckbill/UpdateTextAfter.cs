using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdateTextAfter : MonoBehaviour
{
    public TextMeshPro textToShowCheckbill;
    public static bool checkbill = false;
    void Start()
    {
        textToShowCheckbill.gameObject.SetActive(checkbill);
    }

    void Update()
    {
        if (checkbill)
        {
            textToShowCheckbill.gameObject.SetActive(true);
        }
    }

}
