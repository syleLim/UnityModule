using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicPlayerController : MonoBehaviour
{
	// Default Physics Component
	private Rigidbody2D	rb2D;
	private Animator	animator;
	
	// Get Input and apply horizontal movement 
	private float		moveDirection;
	public float		playerVelocity;

	// Object's rotation setting, default = 1(Right)
	private int			FacingDirecion;
	
	private void Start()
	{
		rb2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
		FacingDirecion = 1;
	}

	private void Update()
	{
		CheckInput();
		CheckFacingDirection();
	}

	private void FixedUpdate()
	{
		applyMovement();	
	}

	private void CheckInput()
	{
		moveDirection = Input.GetAxisRaw("horizontal");
	}

	private void CheckFacingDirection()
	{
		// This condition can be changed anytime.
		if (moveDirection.x * FacingDirecion < 0)
			Flip();
	}

	private void applyMovement()
	{
		rb2D.velocity = new Vector2(playerVelocity * moveDirection, rb2D.velocity.y);
	}

	private void Flip()
	{
		FacingDirecion *= -1;
		transform.Rotate(0.0f, 180.0f, 0.0f);
	}
}
