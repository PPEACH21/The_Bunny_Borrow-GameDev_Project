using UnityEngine;

public class SpawnOrder2 : MonoBehaviour
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
            AudioManage.instance.PlaySFX("FoodToOrder");
        }
    }
}