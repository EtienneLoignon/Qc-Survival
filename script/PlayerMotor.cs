using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour {

    private Rigidbody controller;

    private float verticalVelocity;
    private float gravity = 14.0f;
    private float jumpForce = 400f;

    private bool isGrounded;

    private float disToGround;
    private bool grounded;

    Collider col;

    // Use this for initialization
    private void Start () {
        controller = GetComponent<Rigidbody>();
        col = GetComponent<Collider>();
        disToGround = col.bounds.extents.y;
    }

    void FixedUpdate()
    {
        grounded = Physics.Raycast(transform.position, -Vector3.up, disToGround + 0.1f);
        

    }


    // Update is called once per frame
    private void Update () {
		
        if(grounded)
        {

            verticalVelocity = -gravity * Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                controller.AddForce(0, jumpForce, 0);
            }
        }
        else
             
        {

            verticalVelocity -= gravity * Time.deltaTime;

        }

        Vector3 moveVector = Vector3.zero;
        moveVector.x = Input.GetAxis("Horizontal") * 5.0f ;
        moveVector.y = verticalVelocity;
        moveVector.z = Input.GetAxis("Vertical") * 5.0f ;
        controller.AddForce(moveVector * Time.deltaTime);

    }
}
