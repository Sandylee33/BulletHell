using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation  {
	
	public Vector3 rot;
	public int speed;

	public rotation(Vector3 rotation)
	{
		rot = rotation;
		speed = 1;
	}

	public Vector3 GetRotation()
	{
		return rot * speed;
	}


	public void Accelerate()
	{
		speed = speed * 2;
	}

}
