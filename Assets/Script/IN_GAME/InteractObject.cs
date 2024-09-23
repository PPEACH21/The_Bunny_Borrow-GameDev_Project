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
    public float InteractRange;
    public float raycastHeightOffset = 1.0f; // เพิ่มตัวแปรเพื่อปรับระดับความสูงของ Raycast

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            // ปรับตำแหน่งเริ่มต้นของ Raycast ให้สูงขึ้นตามแกน Y
            Vector3 adjustedPosition = InteractorSource.position + Vector3.up * raycastHeightOffset;

            Ray r = new Ray(adjustedPosition, InteractorSource.forward);
            if (Physics.Raycast(r, out RaycastHit hitInfo, InteractRange))
            {
                if (hitInfo.collider.gameObject.TryGetComponent(out IInteractable interactObject))
                {
                    interactObject.Interact();
                }
            }
        }
        Debug.DrawRay(InteractorSource.position + Vector3.up * raycastHeightOffset, InteractorSource.forward * InteractRange, Color.red);
    }
}