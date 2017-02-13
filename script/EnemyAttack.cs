using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {

    public float timeBetweenAttacks = 0.5f;
    public int attackDamage = 5;

    Animator anim;
    GameObject player;
    Animator playerAnim;
    PlayerHealth playerHealth;
    EnemyHealth enemyHealth;
    bool playerInRange;
    float timer;
    
    


	// Use this for initialization
	void Awake () {

        player = GameObject.FindGameObjectWithTag ("Player");
        playerHealth = player.GetComponent<PlayerHealth> ();
        playerAnim = player.GetComponent<Animator>();
        enemyHealth = GetComponent<EnemyHealth>();
        anim = GetComponent<Animator> ();
        
    }
	
	// Update is called once per frame
	void OnTriggerEnter (Collider col) {
		
        if(col.gameObject.tag == "Player")
        {
            //Debug.Log("Trigger");
            playerInRange = true;

        }


    }

    void OnTriggerExit(Collider col)
    {

        if (col.gameObject.tag == "Player")
        {
            playerInRange = false;
        }


    }

    void Update()
    {
        timer += Time.deltaTime;
        //Debug.Log(enemyHealth.currentHealth);
        if (timer >= timeBetweenAttacks && playerInRange && enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
        {
            
            Attack();
        }

       

    }

    void Attack ()
    {
        timer = 0f;
        Debug.Log("Attack");
        if (playerHealth.currentHealth > 0)
        {
            playerHealth.TakeDamage(attackDamage);
            playerAnim.SetTrigger("Damage");
        }
        if (playerHealth.currentHealth <= 0)
        {
            Debug.Log("Cubie mort");
        }

    }


}
