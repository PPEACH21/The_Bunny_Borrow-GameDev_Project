using UnityEngine;

public class SPAT2 : MonoBehaviour
{
    public GameObject prefabToSpawn1;
    public GameObject prefabToSpawn2;
    public Transform spawnPoint;
    private GameObject spawnedObject;
    public static bool hasSpawned = false;

    public void SpawnPrefab(int n)
    {
        if (!hasSpawned)
        {   
            if(n==1) {
                spawnedObject = Instantiate(prefabToSpawn1, spawnPoint.position, spawnPoint.rotation);
            }
            else if(n == 2)
            {
                spawnedObject = Instantiate(prefabToSpawn2, spawnPoint.position, spawnPoint.rotation);
            }               
            spawnedObject.name = "TB2";
            hasSpawned = true;
            AudioManage.instance.PlaySFX("Welcome");
        }
    }
}