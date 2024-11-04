using UnityEngine;

public class DestroyCustomer : MonoBehaviour, IInteractable
{
    public void Interact()
    {
            Debug.Log(gameObject.name);
            switch (gameObject.name)
            {
                case "Customer1(Clone)":
                if (!SPAT1.hasSpawned)
                {
                    FindObjectOfType<SPAT1>().SpawnPrefab();
                    Destroy(gameObject);
                    Debug.Log("Success");
                    AnimationRes.defaultAnimation = "Showhand";
                    Datainfo.CountTable1 = 1;
                }
                else if (!SPAT2.hasSpawned)
                {
                    FindObjectOfType<SPAT2>().SpawnPrefab(1);
                    Destroy(gameObject);
                    Debug.Log("Success");
                    AnimationRes.defaultAnimation = "Showhand";
                    Datainfo.CountTable2 = 1;
                }
                else if (!SPAT3.hasSpawned)
                {
                    FindObjectOfType<SPAT3>().SpawnPrefab(1);
                    Destroy(gameObject);
                    Debug.Log("Success");
                    AnimationRes.defaultAnimation = "Showhand";
                    Datainfo.CountTable3 = 1;
                }
                else if (!SPAT4.hasSpawned)
                {
                    FindObjectOfType<SPAT4>().SpawnPrefab(1);
                    Destroy(gameObject);
                    Debug.Log("Success");
                    AnimationRes.defaultAnimation = "Showhand";
                    Datainfo.CountTable4 = 1;
                }
                else
                {
                    Debug.Log("NOBODY S1");
                    AudioManage.instance.PlaySFX("Alert");
                }
                break;
                case "Customer2(Clone)":
                    if (!SPAT2.hasSpawned)
                    {
                        FindObjectOfType<SPAT2>().SpawnPrefab(2);
                        Destroy(gameObject);
                        Debug.Log("Success");
                        AnimationRes2.defaultAnimation = "Showhand";
                        Datainfo.CountTable2 = 2;
                    }
                    else if (!SPAT3.hasSpawned)
                    {
                        FindObjectOfType<SPAT3>().SpawnPrefab(2);
                        Destroy(gameObject);
                        Debug.Log("Success");
                        AnimationRes2.defaultAnimation = "Showhand";
                        Datainfo.CountTable3 = 2;
                    }
                    else if (!SPAT4.hasSpawned)
                    {
                        FindObjectOfType<SPAT4>().SpawnPrefab(2);
                        Destroy(gameObject);
                        Debug.Log("Success");
                        AnimationRes2.defaultAnimation = "Showhand";
                        Datainfo.CountTable4 = 2;
                    }
                    else
                    {
                        Debug.Log("NOBODY S2");
                        AudioManage.instance.PlaySFX("Alert");
                }
                break;
                case "Customer3(Clone)":
                    if (!SPAT3.hasSpawned)
                    {
                        FindObjectOfType<SPAT3>().SpawnPrefab(3);
                        Destroy(gameObject);
                        Debug.Log("Success");
                        AnimationRes3.defaultAnimation = "Showhand";
                        Datainfo.CountTable3 = 3;
                    }
                    else if (!SPAT4.hasSpawned)
                    {
                        FindObjectOfType<SPAT4>().SpawnPrefab(3);
                        Destroy(gameObject);
                        Debug.Log("Success");
                        AnimationRes3.defaultAnimation = "Showhand";
                        Datainfo.CountTable4 = 3;
                    }
                    else
                    {
                        Debug.Log("NOBODY S3");
                        AudioManage.instance.PlaySFX("Alert");
                }
                break;
                case "Customer4(Clone)":
                    if (!SPAT4.hasSpawned)
                    {
                        FindObjectOfType<SPAT4>().SpawnPrefab(4);
                        Destroy(gameObject);
                        Debug.Log("Success");
                        AnimationRes4.defaultAnimation = "Showhand";
                        Datainfo.CountTable4 = 4;
                    }
                    else
                    {
                        Debug.Log("NOBODY S4");
                        AudioManage.instance.PlaySFX("Alert");
                }
                break;
                default:
                    // Optional: Handle cases where the name doesn't match any of the above
                    break;
            }
    }
}
