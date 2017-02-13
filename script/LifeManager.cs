using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeManager : MonoBehaviour {

    public int startingLives;
    private int lifeCounter;

    private Text theText;

    public GameObject player;

    // Use this for initialization
    void Start () {

        theText = GetComponent<Text>();

        lifeCounter = startingLives;

        player = GameObject.FindGameObjectWithTag("Player");

    }
	
	// Update is called once per frame
	void Update () {
        theText.text = "x " + lifeCounter;
        if(lifeCounter < 0)
        {
            player.gameObject.SetActive(false);
        }

    }


    public void GiveLife()
    {
        lifeCounter++;
    }

    public void TakeLife()
    {
        lifeCounter--;
    }


}
