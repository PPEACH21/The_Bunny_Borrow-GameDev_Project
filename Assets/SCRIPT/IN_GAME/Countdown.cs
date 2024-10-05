using UnityEngine;
using System.Collections;

public class Countdown : MonoBehaviour
{
    public float timeLeft = 5.0f; // เวลาเริ่มต้น
    void Update()
    {
        timeLeft -= Time.deltaTime;

        if (timeLeft < 0)
        {
            switch (gameObject.name)
            {
                case "Carrot 1(Clone)":
                        Destroy(gameObject);
                        AnimationRes.defaultAnimation = "Showhand";
                        UpdateTextAfter.checkbill = true;
                        
                        
                    break;
                case "Carrot 2(Clone)":
                        Destroy(gameObject);
                        AnimationRes2.defaultAnimation = "Showhand";
                        UpdateTextAfter2.checkbill = true;
                        
                    break;
                case "Carrot 3(Clone)":
                        Destroy(gameObject);
                        AnimationRes3.defaultAnimation = "Showhand";
                        UpdateTextAfter3.checkbill = true;
                        
                    break;
                case "Carrot 4(Clone)":
                        Destroy(gameObject);
                        AnimationRes4.defaultAnimation = "Showhand";
                        UpdateTextAfter4.checkbill = true;
                        
                    break;
                default:
                    // Optional: Handle cases where the name doesn't match any of the above
                    break;
            }
            enabled = false;
        }
    }
}