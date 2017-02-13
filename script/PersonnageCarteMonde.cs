using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonnageCarteMonde : MonoBehaviour {

    public float initialSpeed = 5f;
    public float runMultiplier;
    float moveSpeed = 5;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        moveSpeed = Input.GetKey(KeyCode.RightShift) ? initialSpeed * runMultiplier : initialSpeed;


        
        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            Debug.Log("trigoBougeHori");
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
        }

        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            Debug.Log("trigoBougeVerti");
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
        }
    }
}
