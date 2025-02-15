using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class SimpleCharacterController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 2f;
    public float gravity = -9.81f;
    
    private CharacterController controller;
    private Transform thisTransform;
    private Vector3 velocity;
    
    bool isGrounded = false;
    
    
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        thisTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        MoveCharacter();
        ApplyGravity();
        KeepCharacterOnXAxis();
        
    }
    
    void OnTriggerEnter(Collider other)
    {
        // Check if the trigger collided with a game object tagged as "Ground"
        if (other.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        // Check if the trigger collided with a game object tagged as "Ground"
        if (other.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
    
    private void MoveCharacter()
    {
        //Horizontal movement
        var moveInput= Input.GetAxis("Horizontal");
        var move = new Vector3(moveInput, 0f, 0f) * (moveSpeed * Time.deltaTime);
        controller.Move(move);
        
        //Jumping
        if (Input.GetButtonDown("Jump")) //will not work with: && isGrounded == true
        {
            velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);
            isGrounded = false;
        }
        
    }
    
    private void ApplyGravity()
    {
        if (isGrounded == false) //gravity when not on ground
        {
            velocity.y += gravity * Time.deltaTime;
        }
        else
        {
            velocity.y = 0f; //reset velocity when grounded
        }
        
        //applying the velocity to the controller
        controller.Move(velocity * Time.deltaTime);
        
    }
    
    private void KeepCharacterOnXAxis()
    {
        var currentPosition = thisTransform.position;
        currentPosition.z = 0f;
        thisTransform.position = currentPosition;
    }
    
}
