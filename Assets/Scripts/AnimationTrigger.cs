using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    public Animator animator;
    public string animationName;

    private void OnTriggerEnter(Collider other)
    {
        animator.Play(animationName);
    }
}
