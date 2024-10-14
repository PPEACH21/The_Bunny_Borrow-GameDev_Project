using UnityEngine;

public class FireworkOnClick : MonoBehaviour
{
    public ParticleSystem fireworkEffect; // ลาก Particle System ที่สร้างไว้มาใส่ในช่องนี้

    void OnMouseDown()
    {
        if (fireworkEffect != null)
        {
            fireworkEffect.Play(); // เล่นเอฟเฟคพลุ
        }
        else
        {
            Debug.LogError("ไม่ได้ใส่ Particle System ในช่อง fireworkEffect");
        }
    }
}