using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorScript : MonoBehaviour
{
    public int loopsToStopAt = 3;
    int currentLoop;

    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void StopAnimation()
    {
        if (loopsToStopAt == currentLoop)
        {
            animator.enabled = false;
        }
        currentLoop++;
    }
}
