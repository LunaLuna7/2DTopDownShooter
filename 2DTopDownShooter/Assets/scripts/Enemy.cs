using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public Transform[] patrolAreas;
    public Transform target;

    public float speed;
    public float waitTime;
    public float startWaitTime;

    public bool patrolling;
    public bool chasing;

    private int areaToPatrol;
    void Start()
    {
        waitTime = startWaitTime;
        areaToPatrol = Random.Range(0, patrolAreas.Length);
    }

    void Update()
    {

        if (patrolling)
        {
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
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
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
}
