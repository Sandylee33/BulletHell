using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletmove : MonoBehaviour {



	//public int bullet_kind = 2;

	private Rigidbody2D rb2d;
	public int speed;
	// Use this for initialization
	void Start () 
	{
		Bullets.bullets [0].direction = transform.up;
		Bullets.bullets [1].direction = transform.up;
		rb2d = GetComponent<Rigidbody2D> ();
		rb2d.velocity = BossModes.current_bossmode.mode_bullet.GetVelocity() * -1;
		StartCoroutine (ChangeDirectionbyTime (1, Bullets.bullets [1]));

	}
	
	IEnumerator ChangeDirectionbyTime(int sec, Bullet bullet)
	{
		yield return new WaitForSecondsRealtime (sec);
		bullet.direction = transform.right; 
		rb2d.velocity = BossModes.current_bossmode.mode_bullet.GetVelocity() * -1;

	}


	void Update()
	{
		//rb2d.velocity = BossModes.current_bossmode.mode_bullet.GetVelocity() * -1;
	}

}
