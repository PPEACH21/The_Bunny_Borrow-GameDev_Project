using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSP1 : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public static bool hasSpawned = false;

    public void SpawnPrefab()
    {
        if (!hasSpawned)
        {
            // ใช้ transform.position และ transform.rotation ของ prefabToSpawn เอง
            Instantiate(prefabToSpawn, prefabToSpawn.transform.position, prefabToSpawn.transform.rotation);
            hasSpawned = true;
            AudioManage.instance.PlaySFX("FoodToOrder");
        }
    }
}