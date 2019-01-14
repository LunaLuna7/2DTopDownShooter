using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public Transform[] patrolAreas; //positions to move from
    public Transform target;

    public float speed;
    public float attackRange;
    public float waitTime;
    public float startWaitTime;

    public bool patrolling;
    public bool chasing;

    private int areaToPatrol;
    void Start()
    {
        patrolling = true;
        waitTime = startWaitTime;
        areaToPatrol = Random.Range(0, patrolAreas.Length);
    }

    void Update()
    {

        if (patrolling)
        {
            Look(patrolAreas[areaToPatrol]);
            transform.position = Vector2.MoveTowards(transform.position, patrolAreas[areaToPatrol].position, speed * Time.deltaTime);

            if (Vector2.Distance(transform.position, patrolAreas[areaToPatrol].position) <= 2)
            {
                if (waitTime <= 0)
                {
                    areaToPatrol = Random.Range(0, patrolAreas.Length);
                    waitTime = startWaitTime;
                }
                else
                {
                    waitTime -= Time.deltaTime;
                }
            }
        }
        else if (chasing)
        {


            Look(target);

            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            if(Vector2.Distance(transform.position, target.position) <= attackRange)
            {
                Debug.Log("attack");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            patrolling = false;
            chasing = true;
        }
    }

    private void Look(Transform toLook)
    {
        Vector3 dir = toLook.position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
