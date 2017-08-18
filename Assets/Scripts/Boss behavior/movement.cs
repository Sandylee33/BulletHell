using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement {

	public Vector3 direction;
	public int speed;

	public movement (Vector3 dir)
	{
		direction = dir;
		speed = 1;
	}


	public Vector3 GetMovement()
	{
		return direction * speed;
	}

	public void Accelerate()
	{
		speed *= 2;
	}
}
