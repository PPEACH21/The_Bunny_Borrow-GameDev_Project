using UnityEngine;

public class SpawnOrder1 : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public Transform spawnPoint;
    public static bool hasSpawned = false;

    public void SpawnPrefab()
    {
        if (!hasSpawned)
        {
            GameObject spawnedObject = Instantiate(prefabToSpawn, spawnPoint.position, spawnPoint.rotation);
            spawnedObject.name = "FTB1";
            hasSpawned = true;
            AudioManage.instance.PlaySFX("Food");
        }
    }
}