using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationRes : MonoBehaviour
{
    public Animator animator;
    void Update()
    {
        animator.Play("Showhand");
    }
}
