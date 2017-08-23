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

		mode_bullet = null;

		hitPoints = 50;
		end = false;
	}

	public void Switch(Modes mod)
	{
		BossModes.current_bossmode = mod;
	}

//	Modes mod = new Modes ();

//	mod.mod_id = 1;


}


public static class BossModes
{
	public static List<Modes> bossmodes = new List<Modes> ();

	public static Modes current_bossmode;

	public static void Init(int modes)
	{
		for (int i = 0; i < modes; i++) 
		{
			bossmodes.Add (new Modes (i));
		}

		current_bossmode = bossmodes [0];
	}


}



