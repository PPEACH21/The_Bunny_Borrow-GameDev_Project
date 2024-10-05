using UnityEngine;

public class Destroy : MonoBehaviour
{
    public string tagName = "ToDelete"; // เปลี่ยนชื่อ Tag ตามต้องการ

    void Start()
    {
        GameObject[] objectsToDelete = GameObject.FindGameObjectsWithTag(tagName);

        foreach (GameObject obj in objectsToDelete)
        {
            Destroy(obj);
        }
    }
}