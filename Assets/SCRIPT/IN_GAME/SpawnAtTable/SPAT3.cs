using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class SPAT3 : MonoBehaviour
{
    public GameObject prefabToSpawn3;
    public GameObject prefabToSpawn2;
    public GameObject prefabToSpawn1;
    public Transform spawnPoint;
    public static bool hasSpawned = false;

    public void SpawnPrefab()
    {
        if (!hasSpawned)
        {
            //if()
            Instantiate(prefabToSpawn, spawnPoint.position, spawnPoint.rotation);
            hasSpawned = true;
            AudioManage.instance.PlaySFX("Welcome");
        }
    }
}