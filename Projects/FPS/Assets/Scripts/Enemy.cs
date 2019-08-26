﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System.Linq;

public class Enemy : MonoBehaviour
{
    [Header("Stats")]
    public int curHP;
    public int maxHP;
    public int scoreToGive;

    [Header("Movement")]
    public float moveSpeed;
    public float attackRange;
    public float yPathOffset;

    private List<Vector3> path;

    private Weapon weapon;
    private GameObject target;

    void Start()
    {
        // get the components
        weapon = GetComponent<Weapon>();
        target = FindObjectOfType<Player>().gameObject;

        InvokeRepeating("UpdatePath", 0.0f, 0.5f);
    }

    void Update()
    {
        float dist = Vector3.Distance(transform.position, target.transform.position);

        if (dist <= attackRange)
        {
            if (weapon.CanShoot())
            {
                weapon.Shoot();
            }
        }
        else
        {
            ChaseTarget();
        }

        // look at the target
        Vector3 dir = (target.transform.position - transform.position).normalized;
        float angle = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg;

        transform.eulerAngles = Vector3.up * angle;
    }

    void ChaseTarget()
    {
        // don't make the enemy move if there is no path corner available (i.e. the enemy is next to the player)
        if (path.Count == 0)
        {
            return;
        }

        // move towards the closest path corner
        transform.position = Vector3.MoveTowards(transform.position, path[0] + new Vector3(0, yPathOffset, 0), moveSpeed * Time.deltaTime);

        if (transform.position == path[0] + new Vector3(0, yPathOffset, 0))
        {
            path.RemoveAt(0);
        }
    }

    void UpdatePath()
    {
        // calculate a path to the target
        NavMeshPath navMeshPath = new NavMeshPath();
        NavMesh.CalculatePath(transform.position, target.transform.position, NavMesh.AllAreas, navMeshPath);

        // save that as a list
        path = navMeshPath.corners.ToList();
    }

    public void TakeDamage (int damage)
    {
        curHP -= damage;

        if (curHP <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}