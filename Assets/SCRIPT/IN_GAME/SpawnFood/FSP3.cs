using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSP3 : MonoBehaviour
{
    public GameObject prefabToSpawn1;
    public GameObject prefabToSpawn2;
    public GameObject prefabToSpawn3;
    public static bool hasSpawned = false;
    GameObject spawnedObject;

    public void SpawnPrefab()
    {
        if (!hasSpawned)
        {
            if (Datainfo.CountTable3 == 1)
            {
                spawnedObject = Instantiate(prefabToSpawn1, new Vector3(96.99f, 10.61f, 42.9f), prefabToSpawn1.transform.rotation);
            }
            else if (Datainfo.CountTable3 == 2)
            {
                spawnedObject = Instantiate(prefabToSpawn2, new Vector3(84.6f, -40f, -22.5f), prefabToSpawn2.transform.rotation);
            }
            else if (Datainfo.CountTable3 == 3)
            {
                spawnedObject = Instantiate(prefabToSpawn3, prefabToSpawn3.transform.position, prefabToSpawn3.transform.rotation);
            }
            spawnedObject.name = "FSTB3";
            hasSpawned = true;
            AudioManage.instance.PlaySFX("FoodToOrder");
        }
    }
}