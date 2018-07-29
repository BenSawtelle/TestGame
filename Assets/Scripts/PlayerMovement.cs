using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float moveSpeed;
    private float maxSpeed = 70f;

    private Vector3 input;

    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        input = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Jump"), Input.GetAxis("Vertical"));
        if (rb.velocity.magnitude <= maxSpeed)
        {
            rb.AddForce(input * moveSpeed);
        }
        print(input);
    }
}
