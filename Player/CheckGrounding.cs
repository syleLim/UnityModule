using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicPlayerController : MonoBehaviour
{
	/*
	*	Grounding Check with sub-objs players
	*/
	private bool		isGrounded;
	public Transform	groundCheck;
	// Groud Layer object;
    public LayerMask	WhatIsGround;
	public float		groundCheckRadius;
	
	private void FixedUpdate()
	{
        CheckGroundings();
    }

	private void CheckGroundings()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, WhatIsGround);
    }

	// Draw groucd Check range
	private void OnDrawGizmos()
	{
        Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
    }
}