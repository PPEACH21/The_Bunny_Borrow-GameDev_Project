using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSP4 : MonoBehaviour
{
    public GameObject prefabToSpawn1;
    public GameObject prefabToSpawn2;
    public GameObject prefabToSpawn3;
    public GameObject prefabToSpawn4;
    public static bool hasSpawned = false;
    GameObject spawnedObject;

    public void SpawnPrefab()
    {
        if (!hasSpawned)
        {
            if (Datainfo.CountTable4 == 1)
            {
                spawnedObject = Instantiate(prefabToSpawn1, new Vector3(96.6f, 10.73f, 14.98f), prefabToSpawn1.transform.rotation);
            }
            else if (Datainfo.CountTable4 == 2)
            {
                spawnedObject = Instantiate(prefabToSpawn2, new Vector3(84.4f, -40.9f, -49.9f), prefabToSpawn2.transform.rotation);//
            }
            else if (Datainfo.CountTable4 == 3)
            {
                spawnedObject = Instantiate(prefabToSpawn3, new Vector3(154f, -34f, -53.6f), prefabToSpawn3.transform.rotation);
            }
            else if (Datainfo.CountTable4 == 4)
            {
                spawnedObject = Instantiate(prefabToSpawn4, prefabToSpawn4.transform.position, prefabToSpawn4.transform.rotation);
            }
            spawnedObject.name = "FSTB4";
            hasSpawned = true;
            AudioManage.instance.PlaySFX("FoodToOrder");
        }
    }
}