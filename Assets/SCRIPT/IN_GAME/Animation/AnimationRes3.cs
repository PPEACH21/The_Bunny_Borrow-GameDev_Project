using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationRes3 : MonoBehaviour
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
