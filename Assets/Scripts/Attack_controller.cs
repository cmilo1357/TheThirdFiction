using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_controller : MonoBehaviour
{
    [SerializeField] Animator animator;
    Collider2D collider;

    public void Awake()
    {
        collider = GetComponent<Collider2D>();
        collider.enabled = false;
    }

    public void AttackStart()
    {
        animator.SetBool("shooting", true);
        collider.enabled = true;
    }

    public void AttackFinish()
    {
        animator.SetBool("shooting", false);
        collider.enabled = false;
    }
}
