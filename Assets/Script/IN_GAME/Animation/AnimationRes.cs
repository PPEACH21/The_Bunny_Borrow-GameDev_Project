using UnityEngine;

public class AnimationRes : MonoBehaviour
{
    public Animator animator;
    public static string defaultAnimation = "Showhand";


    void Start()
    {
        animator.Play(defaultAnimation);
    }
    private void Update()
    {
        animator.Play(defaultAnimation);
    }
}