using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour, IInteractable
{
    // Start is called before the first frame update
    public void Interact()
    {
        Debug.Log("Object interacted with: " + gameObject.name);
    }
}
