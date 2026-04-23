using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    public float speed = 0; 

   
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent <Rigidbody>();
    }

    // Update is called once per frame
    void OnMove (InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;

        Debug.Log("Move triggered");
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3 (movementX, 1.0f, movementY);

        rb.AddForce(movement * speed);
 
    }

}
