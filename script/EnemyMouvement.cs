﻿using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMouvement : MonoBehaviour {

    public float enemySpeed;
    //bool canFlip = true;
    //bool facingRight = false;
    //float flipTime = 5f;





    Transform player;               // Reference to the player's position.
    //PlayerHealth playerHealth;      // Reference to the player's health.
    //EnemyHealthManager enemyHealth;        // Reference to this enemy's health.
    NavMeshAgent nav;               // Reference to the nav mesh agent.


    void Awake()
    {
        // Set up the references.
        player = GameObject.FindGameObjectWithTag("Player").transform;
        //playerHealth = player.GetComponent<PlayerHealth>();
        //enemyHealth = GetComponent<EnemyHealth>();
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update () {
        // If the enemy and the player have health left...
        //if (enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
        // {
        // ... set the destination of the nav mesh agent to the player.
        nav.SetDestination(player.position);
        // }
        // Otherwise...
        // else
        // {
        // ... disable the nav mesh agent.
        //    nav.enabled = false;
        // }
 
    }
}
