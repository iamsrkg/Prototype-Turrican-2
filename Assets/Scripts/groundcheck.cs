using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundcheck : MonoBehaviour
{
    private Animator animator;
    public int collisions = 0;

    private void Start()
    {
        animator = GetComponentInParent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collisions++;
        animator.SetBool("grounded", true);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        collisions--;
        if (collisions == 0)
        {
            animator.SetBool("grounded", false);
        }
    }

}
