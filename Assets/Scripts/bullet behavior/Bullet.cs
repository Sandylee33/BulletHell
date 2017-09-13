using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet  {

	public int bullet_id;
	public Sprite bullet_sprite;
	public int speed;
	public Vector3 direction;

	public Bullet(BulletBehaviorTemplate template)
	{
		bullet_id = template.id;
		speed = template.speed;
		bullet_sprite = template.sprite;
		direction = template.direction;

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

	public static void Init(int kind, BulletBehaviorTemplate template)
	{
		for (int i = 0; i < kind; i++) {
			bullets.Add (new Bullet (template));
		}

		current_bullet = bullets [0];
		Bullets.bullets [0].bullet_id = 0;
		Bullets.bullets [1].bullet_id = 1;
	}
}
