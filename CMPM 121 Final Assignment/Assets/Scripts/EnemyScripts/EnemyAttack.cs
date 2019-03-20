using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterStats))]
public class EnemyAttack : MonoBehaviour
{
    public float attackSpeed = 1f;
    private float attackCooldown = 0f;
    CharacterStats myStats;

    void Start()
    {
        myStats = GetComponent<CharacterStats>();
    }

    void Update()
    {
        //TheEnemy.GetComponent<Animation>().Play("Idle_1");
        attackCooldown -= Time.deltaTime;
    }
    public void Attack(CharacterStats targetStats)
    {
        if (attackCooldown <= 0f)
        {
            Health.healthValue -= 10f;
            targetStats.TakeDamage(10);
            attackCooldown = 1f / attackSpeed;
        }
       
    }


}
 