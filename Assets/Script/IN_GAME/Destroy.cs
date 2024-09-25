using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Destroy(gameObject);
    }
   
}
