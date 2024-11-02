using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    public float lifetime = 20f;
    public SpriteRenderer spriteRenderer; // SpriteRenderer สำหรับแสดงรูป
    public Sprite[] sprites; // Array ของ Sprite ทั้ง 3 รูป

    private float timer;

    void Start()
    {
        timer = lifetime;

        // ตรวจสอบว่ามี SpriteRenderer และ Sprite ครบถ้วนหรือไม่
        if (spriteRenderer == null)
        {
            Debug.LogError("Sprite Renderer not assigned!");
        }
        if (sprites.Length != 3)
        {
            Debug.LogError("Please assign 3 sprites!");
        }
    }

    void Update()
    {
        timer -= Time.deltaTime;

        // เปลี่ยน Sprite ตามเวลา
        if (timer <= lifetime / 3f)
        {
            spriteRenderer.sprite = sprites[2]; // แสดงรูปที่ 3
        }
        else if (timer <= lifetime * 2f / 3f)
        {
            spriteRenderer.sprite = sprites[1]; // แสดงรูปที่ 2
        }
        else
        {
            spriteRenderer.sprite = sprites[0]; // แสดงรูปที่ 1
        }

        if (timer <= 0)
        {
            if(Datainfo.score-50 >= 0)
            {
                Datainfo.score -= 50;
            }
            Destroy(gameObject);
        }
    }
}