using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroyBar : MonoBehaviour
{
    public List<GameObject> sprites; // List ของ Sprite
    public float totalTime = 20f; // เวลาทั้งหมด
    public float startDelay = 2.2f; // ดีเลย์ก่อนเริ่มลบ (หน่วยเป็นวินาที)

    private float timer; // ตัวจับเวลา
    private int currentPart = 0; // ส่วนของเวลาปัจจุบัน (0, 1, 2)
    private int spriteIndex = 0; // index ของ Sprite ที่จะลบ

    void Start()
    {
        timer = totalTime;
        StartCoroutine(DeleteSprites());
    }

    IEnumerator DeleteSprites()
    {
        yield return new WaitForSeconds(startDelay); // รอ startDelay วินาที

        float timePerPart = totalTime / 3f; // เวลาในแต่ละส่วน
        float delay = timePerPart / 3f; // เวลาในการลบแต่ละ Sprite

        while (timer > 0 && currentPart < 3)
        {
            timer -= Time.deltaTime;

            // ตรวจสอบว่าถึงเวลาเปลี่ยนส่วนหรือยัง
            if (timer <= timePerPart * (2 - currentPart))
            {
                currentPart++;
                spriteIndex = currentPart * 3;
            }

            // ลบ Sprite
            if (spriteIndex < sprites.Count)
            {
                Destroy(sprites[spriteIndex]);
                spriteIndex++;

                yield return new WaitForSeconds(delay); // รอเวลาก่อนลบ Sprite ตัวถัดไป
            }
            else
            {
                yield return null; // รอเฟรมถัดไป ถ้าไม่มี Sprite ให้ลบแล้ว
            }
        }
    }
}