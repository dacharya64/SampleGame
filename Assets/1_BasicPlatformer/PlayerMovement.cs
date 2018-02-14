using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    
    public float speed; //how fast the player moves
    public float jumpForce; //how high the player jumps

    //Private Vars
    private Rigidbody rb;

    // Use this for initialization
    void Start () { 
        //get the rigidbody compoment of what this is attached to (ex. the player)
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.W)) { //JUMP
            rb.velocity = transform.up * jumpForce;
        }
        if (Input.GetKey(KeyCode.A)) { //MOVE LEFT
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D)) { //MOVE RIGHT
            // **How do you rewrite the 'move left' code for moving right?**
            // Answer below
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }
}

/*
 * 
 * 
 * 
 * 
 * 
 * 
 * SOLUTION: transform.position += Vector3.right * speed * Time.deltaTime;
 */