using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public GameObject TheEnemy;
    public float lookRadius = 80f;
    Transform target;
    NavMeshAgent agent;
    EnemyAttack attack;
    // Start is called before the first frame update
    void Start()
    {
        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
        attack = GetComponent<EnemyAttack>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        if (distance <= lookRadius && distance >= agent.stoppingDistance)
        {
            TheEnemy.GetComponent<Animation>().Play("Walk");
            agent.SetDestination(target.position);


        }else if (distance <= agent.stoppingDistance)
            {
                TheEnemy.GetComponent<Animation>().Play("Damage_1");
                CharacterStats targetStats = target.GetComponent<CharacterStats>();
                if (targetStats != null)
                {
                    attack.Attack(targetStats);
                }


            }
        if (distance >= lookRadius)
        {
            TheEnemy.GetComponent<Animation>().Play("Idle_1");
        }

    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position,lookRadius);
    }
}
