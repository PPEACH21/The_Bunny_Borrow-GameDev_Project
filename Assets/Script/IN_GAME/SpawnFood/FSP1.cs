using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSP1 : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public Transform spawnPoint;
    public static bool hasSpawned = false;

    public void SpawnPrefab()
    {
        if (!hasSpawned)
        {
            Instantiate(prefabToSpawn, spawnPoint.position, spawnPoint.rotation);
            hasSpawned = true;
        }
    }
}
