using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modes {
	
	public int mode_id;
	public string mode_desc;
	public rotation mode_rot;
	public movement mode_mov;
	public Bullet mode_bullet;

	public bool end = false;
	public float hitPoints;

	public Modes(int id)
	{
		mode_id = id;
		mode_desc = "";
		mode_rot = new rotation (Vector3.zero);
		mode_mov = new movement (Vector3.zero);
		mode_bullet = new Bullet (7, null);
		hitPoints = 50;
		end = false;
	}

	public void Switch(Modes mod)
	{
		BossModes.bossmode = mod;
	}

//	Modes mod = new Modes ();

//	mod.mod_id = 1;


}


public static class BossModes
{
	public static Modes bossmode = new Modes(0);

	public static void Init()
	{
	  	bossmode = new Modes (0);

	}


}



