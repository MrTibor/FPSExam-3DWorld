using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;


public class EnemyMove : MonoBehaviour
{
    public float moveSpeed, distanceToStop;

    private Vector3 target;

    public NavMeshAgent agent;

    public GameObject bullet;
    public Transform firePoint;

    public float fireRate;
    private float fireCount;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        target = PlayerMove.instance.transform.position;
        //target.y = transform.position.y;

        agent.destination = target;


        //transform.LookAt(target);

        //theRigidbody.velocity = transform.forward * moveSpeed;

        if (Vector3.Distance(transform.position, target) > distanceToStop)
        {
            agent.destination = target;
        } else
        {
            agent.destination = transform.position;
        }

        fireCount -= Time.deltaTime;

        if (fireCount <= 0)
        {
            fireCount = fireRate;

            firePoint.LookAt(PlayerMove.instance.transform.position + new Vector3(0f, 1.7f, 0f));

            Vector3 targetDirection = PlayerMove.instance.transform.position - transform.position;
            float angle = Vector3.SignedAngle(targetDirection, transform.forward, Vector3.up);

            if (Mathf.Abs(angle) < 25f)
            {
                Instantiate(bullet, firePoint.position, firePoint.rotation);

                animator.SetTrigger("fire");
            }
            else
            {
                agent.destination = target;
            }

            if (agent.remainingDistance < 0.3f)
            {
                animator.SetBool("isMoving", false);
            }
            else
            {
                animator.SetBool("isMoving", true);
            }

        }


    }
}
