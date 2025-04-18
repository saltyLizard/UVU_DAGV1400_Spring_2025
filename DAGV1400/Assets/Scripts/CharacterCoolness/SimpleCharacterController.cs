using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(AudioSource))]
public class SimpleCharacterController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 2.5f;
    public float gravity = -9.81f;

    private CharacterController controller;
    private Transform thisTransform;
    private Vector3 velocity;
    
    private bool isJumping = false;
    
    private AudioSource audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        thisTransform = transform;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveCharacter();
        ApplyGravity();
        KeepCharacterOnXAxis();
        GameQuit();
        
        //Jumping
        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            velocity.x = 0f;
            velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);
            isJumping = true;
            audioSource.Play();
        }
        
        isJumping = false;
        
    }

    private void GameQuit()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
    
    private void MoveCharacter()
    {
        if (!isJumping)
        {
            // Horizontal movement
            var moveInput= Input.GetAxis("Horizontal");
            var move = new Vector3(moveInput, 0f, 0f) * (moveSpeed * Time.deltaTime);
            controller.Move(move);
        }
        
    }
    
    private void ApplyGravity()
    {
        if (!controller.isGrounded) //gravity when not on ground
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