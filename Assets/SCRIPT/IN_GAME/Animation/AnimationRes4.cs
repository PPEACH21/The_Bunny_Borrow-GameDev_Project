using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationRes4 : MonoBehaviour
{
    public Animator animator;
    public static string defaultAnimation = "Showhand";
    public static bool check = false;

    void Start()
    {
        animator.Play(defaultAnimation);
    }

    private void Update()
    {
        animator.Play(defaultAnimation);
    }
}
