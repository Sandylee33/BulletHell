using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modes {

	public int mode_id;
	public string mode_desc;
	public Vector3 mode_rot;
	public bulletmove mode_bullet_move;

	public bool end = false;
	public float hitPoints;

	public Modes(int id, string desc, Vector3 rot, bulletmove bullet_move)
	{
		mode_id = id;
		mode_desc = desc;
		mode_rot = rot;
		mode_bullet_move = bullet_move;
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
	public static Modes bossmode = new Modes(0,"",Vector3.forward,null);

	public static void Init()
	{
		bossmode = new Modes (0,"",Vector3.zero,null);

	}


}



