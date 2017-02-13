using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public int startingHealth = 100;
    public int currentHealth;
    public Slider healthSlider;
    public Image damageImage;
    public AudioClip deathClip;
    public float flashSpeed = 5f;
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);

    public GameObject currentCheckpoint;

    private PlayerController player;

    private LifeManager lifeSystem;

    Animator anim;
    AudioSource playerAudio;
    PlayerController playerController;

    bool isDead;
    bool damaged;

    void Awake()
    {
        anim = GetComponent<Animator> ();
        playerAudio = GetComponent<AudioSource>();
        playerController = GetComponent<PlayerController>();

        currentHealth = startingHealth;

        lifeSystem = FindObjectOfType<LifeManager>();

        isDead = false;

    }
	
	// Update is called once per frame
	void Update () {
		if(damaged)
        {
            damageImage.color = flashColour;
        }
        else
        {
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }
        damaged = false;


    }
    public void TakeDamage(int amount)
    {
        damaged = true;
        //Debug.Log(currentHealth);
        currentHealth -= amount;

        healthSlider.value = currentHealth;

        playerAudio.Play ();

        if(currentHealth <= 0 && !isDead)
        {
            Death ();
        }

    }

    void Death()
    {
        //Debug.Log("mort");
        isDead = true;

        //anim.SetTrigger("Die");

        playerAudio.clip = deathClip;
        playerAudio.Play();

        playerController.enabled = false;
        lifeSystem.TakeLife();
        Debug.Log(this.gameObject);
        this.gameObject.SetActive(false);
    }

    public void RespawnPlayer()

    {
        Debug.Log("Player Respawn");
        player.transform.position = currentCheckpoint.transform.position;
        playerController.enabled = true;
        this.gameObject.SetActive(true);
        isDead = false;
    }

}
