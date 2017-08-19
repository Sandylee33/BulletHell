using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet  {

	public int bullet_id;
	public Sprite bullet_sprite;
	public int speed;
	public Vector3 direction;

	public Bullet(int spd, Sprite pic)
	{
		speed = spd;
		bullet_sprite = pic;

	}

	public Vector3 GetVelocity()
	{
		return speed * direction;
	}


}
