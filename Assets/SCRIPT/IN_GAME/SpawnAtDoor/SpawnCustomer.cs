using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class SpawnCustomer : MonoBehaviour
{
    public GameObject[] prefab;
    public Transform target;
    public float checkDistance = 2f;

    private float nextSpawnTime;
    private List<int> availableIndices;
    private bool isTargetOccupied = false;

    private void Start()
    {
        Datainfo.score = 0;
        nextSpawnTime = Time.time + Datainfo.spawnInterval;
        availableIndices = Enumerable.Range(0, prefab.Length).ToList();
        // สร้าง prefab แบบสุ่มเลขทันทีที่เริ่มเกม
        int randomPrefabIndex = Random.Range(0, prefab.Length);
        SpawnPrefab(randomPrefabIndex);
    }

    private void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            Collider[] hitColliders = Physics.OverlapSphere(target.position, checkDistance, LayerMask.GetMask("Prefab"));
            isTargetOccupied = hitColliders.Length > 0;

            if (!isTargetOccupied)
            {
                if (availableIndices.Count == 0)
                {
                    availableIndices = Enumerable.Range(0, prefab.Length).ToList();
                }

                int randomIndex = Random.Range(0, availableIndices.Count);
                int prefabIndex = availableIndices[randomIndex];
                availableIndices.RemoveAt(randomIndex);

                SpawnPrefab(prefabIndex);
                nextSpawnTime = Time.time + Datainfo.spawnInterval;
            }
        }
        Debug.DrawRay(target.position, Vector3.up * checkDistance, Color.red);
        Debug.DrawRay(target.position, Vector3.down * checkDistance, Color.red);
        Debug.DrawRay(target.position, Vector3.left * checkDistance, Color.red);
        Debug.DrawRay(target.position, Vector3.right * checkDistance, Color.red);
        Debug.DrawRay(target.position, Vector3.forward * checkDistance, Color.red);
        Debug.DrawRay(target.position, Vector3.back * checkDistance, Color.red);
    }

    private void SpawnPrefab(int prefabIndex)
    {
        GameObject newPrefab = Instantiate(prefab[prefabIndex], transform.position, Quaternion.identity);
        newPrefab.transform.Rotate(0f, 90f, 0f);
        PrefabMover mover = newPrefab.AddComponent<PrefabMover>();
        mover.SetTarget(target);
        mover.speed = Datainfo.speedcustomer;
        AudioManage.instance.PlaySFX("Walkin");
    }
}

public class PrefabMover : MonoBehaviour
{
    public Animator animator;
    public Transform target;
    public float speed = 2f;
    public bool check;

    private void Start()
    {
        transform.Rotate(0f, 180f, 0f);
        check = false;
    }

    public void SetTarget(Transform newTarget) //set target
    {
        target = newTarget;
    }

    private void Update()
    {
        if (target != null)//move to target
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime); //if on target stop
            if(transform.position == target.position && check == false)
                {
                    check = true;
                }
        }
        
    }
}