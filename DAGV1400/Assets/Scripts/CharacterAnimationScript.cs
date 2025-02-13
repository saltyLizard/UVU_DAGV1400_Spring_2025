using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationScript : MonoBehaviour
{
    
    private Animator animator;

    private void HandleAnimations()
    {
        //Running
        if (Input.GetAxis("Horizontal") != 0)
        {
            animator.SetTrigger("RunTrig");
        }
        
        //Jumping
        if (Input.GetButtonDown("Jump"))
        {
            animator.SetTrigger("JumpTrig");
        }
        
        //Wall Jump!
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("WallJTrig");
        }
        
        //Fall animation test
        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetTrigger("FallTrig");
        }
        
        //Hit animation test
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetTrigger("HitTrig");
        }
       
        //Double Jump, probably will change
        if (Input.GetKeyDown(KeyCode.V))
        {
            animator.SetTrigger("DoubleJTrig");
        }
       
        //Idle
        else
        {
            animator.SetTrigger("IdleTrig");
        }
        
    }
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleAnimations();
    }
}
