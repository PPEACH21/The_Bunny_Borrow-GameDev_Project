using UnityEngine;

public class SPAT4 : MonoBehaviour
{
    public GameObject prefabToSpawn1;
    public GameObject prefabToSpawn2;
    public GameObject prefabToSpawn3;
    public GameObject prefabToSpawn4;
    public Transform spawnPoint;
    public static bool hasSpawned = false;
    private GameObject spawnedObject;

    public void SpawnPrefab(int n)
    {
        if (!hasSpawned)
        {
            if (n == 1)
            {
                spawnedObject = Instantiate(prefabToSpawn1, spawnPoint.position, spawnPoint.rotation);
            }
            else if (n == 2)
            {
                spawnedObject = Instantiate(prefabToSpawn2, spawnPoint.position, spawnPoint.rotation);
            }
            else if (n == 3)
            {
                spawnedObject = Instantiate(prefabToSpawn3, spawnPoint.position, spawnPoint.rotation);
            }else if (n == 4)
            {
                spawnedObject = Instantiate(prefabToSpawn4, spawnPoint.position, spawnPoint.rotation);
            }
            spawnedObject.name = "TB4";
            hasSpawned = true;
            AudioManage.instance.PlaySFX("Welcome");
        }
    }
}