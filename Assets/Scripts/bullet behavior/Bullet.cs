using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet  {

	public int bullet_id;
	public Sprite bullet_sprite;
	public int speed;
	public Vector3 direction;

	public Bullet()
	{
		speed = 7;
		bullet_sprite = null;
		direction = Vector3.zero;

	}

	public Vector3 GetVelocity()
	{
		return speed * direction;
	}




	public static Bullet GetById(int id)
	{
		foreach (Bullet bullet in Bullets.bullets) 
		{
			if (bullet.bullet_id == id) {
				return bullet;
			}
		}
		return null;

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
			bullets.Add (new Bullet ());
		}

		current_bullet = bullets [0];
		Bullets.bullets [0].bullet_id = 0;
		Bullets.bullets [1].bullet_id = 1;
	}
}
