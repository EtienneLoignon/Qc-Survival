using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour {

    private bool playerInZone;

    public string levelToLoad;


	// Use this for initialization
	void Start () {
        playerInZone = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(playerInZone == true)
        {
            SceneManager.LoadScene(levelToLoad);
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Enter");
            playerInZone = true;
        }


    }
    void OnTriggerExit(Collider other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Exit");
            playerInZone = false;
        }


    }

}
