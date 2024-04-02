﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    [SerializeField]
    private float speed = 15.0f;
    private float rotationSpeed = 100.0f;
    private float verticalInput;


// Start is called before the first frame update
void Start()
{

}

// Update is called once per frame
void Update()
{
    // get the user's vertical input
    verticalInput = Input.GetAxis("Vertical");

    // move the plane forward at a constant rate
    // Transform ile nesnenin konumunu hareket ettiririz.
    // Rigidbody velocity ile nesneyi hareket ettiririz.
    transform.Translate(Vector3.forward * Time.deltaTime * speed);


    // tilt the plane up/down based on up/down arrow keys
    transform.Rotate(Vector2.right * Time.deltaTime * rotationSpeed * verticalInput );
}
}
