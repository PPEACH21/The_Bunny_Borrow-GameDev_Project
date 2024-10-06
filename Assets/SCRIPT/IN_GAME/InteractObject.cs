using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IInteractable
{
    public void Interact();
}

public class InteractObject : MonoBehaviour
{
    public Transform InteractorSource;
    public float InteractRange = 8f;
    public float raycastHeightOffset = 10f; // เพิ่มตัวแปรเพื่อปรับระดับความสูง
    public float interactRadius = 8.5f; // กำหนดรัศมีของวงกลม

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            // ปรับตำแหน่งเริ่มต้นของการตรวจจับให้สูงขึ้นตามแกน Y
            Vector3 adjustedPosition = InteractorSource.position + Vector3.up * raycastHeightOffset;

            // ใช้ OverlapSphere เพื่อตรวจหาวัตถุภายในรัศมีที่กำหนด
            Collider[] hitColliders = Physics.OverlapSphere(adjustedPosition, interactRadius);

            foreach (Collider hitCollider in hitColliders)
            {
                // ตรวจสอบว่าวัตถุชนใดๆ ที่อยู่ในรัศมีนั้นมีการ implement IInteractable หรือไม่
                if (hitCollider.gameObject.TryGetComponent(out IInteractable interactObject))
                {
                    interactObject.Interact();
                    break; // หยุดหลังจาก interact กับวัตถุชิ้นแรก
                }
            }
        }

        // แสดงวงกลมใน Editor เพื่อให้เห็นบริเวณการตรวจจับ
        Debug.DrawLine(InteractorSource.position + Vector3.up * raycastHeightOffset,InteractorSource.position + Vector3.up * raycastHeightOffset + InteractorSource.forward * InteractRange, Color.red);
        Debug.DrawRay(InteractorSource.position + Vector3.up * raycastHeightOffset,Vector3.up * interactRadius, Color.green);
    }
}
