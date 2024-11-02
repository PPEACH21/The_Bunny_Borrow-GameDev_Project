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
            case "FTB1":
                if (!FSP1.hasSpawned)
                {
                    FindObjectOfType<FSP1>().SpawnPrefab();
                    Destroy(gameObject);
                    Debug.Log("Success");
                    AnimationRes.defaultAnimation = "Eat";
                }
                break;
            case "FTB2":
                if (!FSP2.hasSpawned)
                {
                    FindObjectOfType<FSP2>().SpawnPrefab();
                    Destroy(gameObject);
                    Debug.Log("Success");
                    AnimationRes2.defaultAnimation = "Eat";
                }
                break;
            case "FTB3":
                if (!FSP3.hasSpawned)
                {
                    FindObjectOfType<FSP3>().SpawnPrefab();
                    Destroy(gameObject);
                    Debug.Log("Success");
                    AnimationRes3.defaultAnimation = "Eat";
                }
                break;
            case "FTB4":
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
