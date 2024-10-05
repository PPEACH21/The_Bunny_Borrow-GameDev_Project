using UnityEngine;

public class CStop : MonoBehaviour
{
    public Animator animator;
    PrefabMover move;

    void Start()
    {
        // Find the PrefabMover component on any game object in the scene
        move = FindObjectOfType<PrefabMover>();

        if (move == null)
        {
            Debug.LogError("No PrefabMover found in the scene!");
        }
    }

    void Update()
    {
        if (move != null && move.check == true)
        {
            animator.Play("waiting action");
        }
    }
}