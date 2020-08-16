using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicPlayerController : MonoBehaviour
{
	private Rigidbody2D	rb2D;
	private Animator	animator;

	public float	jumpForce = 2f;
	public int		amountOfJumps = 1;
	public float	jumpHighierMultiplier = 0.5f;
	private int		amountOfJumpsLeft;

	
	private void Start()
	{
		rb2D = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
		amountOfJumpsLeft = amountOfJumps;
	}

	private void Update()
	{
		CheckInput();
		CheckJump();
	}

	private void CheckInput()
	{
		
	}

	private void CheckJump()
	{

	}

	private void NormalJump()
    {
        if (canNormalJump) // !isWallSliding is wall jump
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpForce);
            amountOfJumpsLeft--;
            jumpTimer = 0;
            isAttemptingToJump = false;
            checkJumpMultiplier = true;
        }   
    }
}