using UnityEngine;

public class DestroyCustomer : MonoBehaviour, IInteractable
{
    public void Interact()
    {
            Debug.Log(gameObject.name);
            switch (gameObject.name)
            {
                case "Cus1(Clone)":
                    if (!SPAT1.hasSpawned)
                    {
                       FindObjectOfType<SPAT1>().SpawnPrefab();
                    Destroy(gameObject);
                    Debug.Log("Success");
                    }
                    break;
                case "Cus2(Clone)":
                    if (!SPAT2.hasSpawned)
                    {
                        FindObjectOfType<SPAT2>().SpawnPrefab();
                    Destroy(gameObject);
                    Debug.Log("Success");
                    }
                break;
                case "Cus3(Clone)":
                    if (!SPAT3.hasSpawned)
                    {
                        FindObjectOfType<SPAT3>().SpawnPrefab();
                    Destroy(gameObject);
                    Debug.Log("Success");
                    }
                break;
                case "Cus4(Clone)":
                    if (!SPAT4.hasSpawned)
                    {
                        FindObjectOfType<SPAT4>().SpawnPrefab();
                    Destroy(gameObject);
                    Debug.Log("Success");
                    }
                break;
                default:
                    // Optional: Handle cases where the name doesn't match any of the above
                    break;
            }
    }
}
