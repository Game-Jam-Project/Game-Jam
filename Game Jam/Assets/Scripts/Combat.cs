using UnityEngine;

public class Combat : MonoBehaviour
{
    [SerializeField] private float attackRate = 2f;
    [SerializeField] private float attackRadious = 2f;
    [SerializeField] private Transform attackPoint;
    [SerializeField] private LayerMask enemyLayers;

    private float nextTimeToAttack;

    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Time.time >= nextTimeToAttack)
        {
            if (Input.GetButtonDown("Fire2"))
            {
                Attack();
                nextTimeToAttack = Time.time + 1f / attackRate;
            }
        }
    }

    private void Attack()
    {
        animator.SetTrigger("Attack");

        Collider2D[] colliders = Physics2D.OverlapCircleAll(attackPoint.position, attackRadious, enemyLayers);

        foreach (Collider2D collider in colliders)
        {
            
        }
    }
}