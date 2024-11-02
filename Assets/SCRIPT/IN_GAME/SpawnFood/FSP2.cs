using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSP2 : MonoBehaviour
{
    public GameObject prefabToSpawn1;
    public GameObject prefabToSpawn2;
    GameObject spawnedObject;
    public static bool hasSpawned = false;

    public void SpawnPrefab(){
        if (!hasSpawned){
            if (Datainfo.CountTable2 == 1) {
                spawnedObject = Instantiate(prefabToSpawn1, new Vector3(51.58f, 10.62f, 40.85f), prefabToSpawn1.transform.rotation);
            }else if(Datainfo.CountTable2 == 2){
                spawnedObject = Instantiate(prefabToSpawn2, prefabToSpawn2.transform.position, prefabToSpawn2.transform.rotation);
            }
            // ใช้ transform.position และ transform.rotation ของ prefabToSpawn เอง

            spawnedObject.name = "FSTB2";
            hasSpawned = true;
            AudioManage.instance.PlaySFX("FoodToOrder");
        }
    }
}