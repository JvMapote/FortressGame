using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    public float runSpeed = 70f;
    
    float horizontalMove = 0f;

    bool jump = false;
    bool crouch = false;
    bool jumping;
    
   
    void Update()
    {
        //animations and getting input
        bool jumping = animator.GetBool("IsJumping");

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
 
       if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        } else if (Input.GetButtonUp("Crouch")) 
        {
            crouch = false;
                    }
    }
    //while landing
    public void OnLanding() 
    {
        animator.SetBool("IsJumping", false);
        if (jumping == false && jump == false)
        {
            SoundManagerScript.PlaySound("JumpingSound");
        }

    }
    //crouch
    public void OnCrouching(bool isCrouching)
    {  
        animator.SetBool("IsCrouching", isCrouching);
    }
    //jumping
    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;


    }
}
