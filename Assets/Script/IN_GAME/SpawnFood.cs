using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Debug.Log(gameObject.name);
        switch (gameObject.name)
        {
            case "Carrot 1(Clone)":
                if (!FSP1.hasSpawned)
                {
                    FindObjectOfType<FSP1>().SpawnPrefab();
                    Destroy(gameObject);
                    Debug.Log("Success");
                    AnimationRes.defaultAnimation = "Eat";
                }
                break;
            case "Carrot 2(Clone)":
                if (!FSP2.hasSpawned)
                {
                    FindObjectOfType<FSP2>().SpawnPrefab();
                    Destroy(gameObject);
                    Debug.Log("Success");
                    AnimationRes2.defaultAnimation = "Eat";
                }
                break;
            case "Carrot 3(Clone)":
                if (!FSP3.hasSpawned)
                {
                    FindObjectOfType<FSP3>().SpawnPrefab();
                    Destroy(gameObject);
                    Debug.Log("Success");
                    AnimationRes3.defaultAnimation = "Eat";
                }
                break;
            case "Carrot 4(Clone)":
                if (!FSP4.hasSpawned)
                {
                    FindObjectOfType<FSP4>().SpawnPrefab();
                    Destroy(gameObject);
                    Debug.Log("Success");
                    AnimationRes4.defaultAnimation = "Eat";
                }
                break;
            default:
                // Optional: Handle cases where the name doesn't match any of the above
                break;
        }
        enabled = false;
    }
}
