using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicPlayerController : MonoBehaviour
{
	private bool		isTouchingWall;
	public Transform	wallCheck;
    public LayerMask	WhatIsGround;
	public float		wallCheckDistance;

	private void FixedUpdate()
	{
		CheckWall();		
	}

	private void CheckWall()
	{
		isTouchingWall = Physics2D.Raycast(wallCheck.position, transform.right, wallCheckDistance, WhatIsGround);
	}

	private void OnDrawGizmos()
	{
		Gizmos.DrawLine(wallCheck.position, new Vector3(wallCheck.position.x + wallCheckDistance, wallCheck.position.y, wallCheck.position.z));	
	}
}