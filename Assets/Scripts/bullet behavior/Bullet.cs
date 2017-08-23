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
		direction = Vector3.zero;

	}

	public Vector3 GetVelocity()
	{
		return speed * direction;
	}




	public int GetId()
	{
		return bullet_id;
	}


}


public static class Bullets
{
	//public static Bullet bullet = new Bullet (7, null);
	public static List<Bullet> bullets = new List<Bullet> ();

	public static Bullet current_bullet;

	public static void Init(int kind)
	{
		for (int i = 0; i < kind; i++) {
			bullets.Add (new Bullet (7, null));
		}

		current_bullet = bullets [0];
	}
}
