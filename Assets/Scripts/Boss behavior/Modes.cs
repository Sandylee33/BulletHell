using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modes {

	public int mode_id;
	public string mode_desc;
	public rotation mode_rot;
	public movement mode_mov;
	public bulletmove mode_bullet_move;

	public bool end = false;
	public float hitPoints;

	public Modes(int id, string desc, rotation rot, bulletmove bullet_move)
	{
		mode_id = id;
		mode_desc = desc;
		mode_rot = rot;
		mode_bullet_move = bullet_move;
		mode_mov = null;
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
	public static Modes bossmode = new Modes(0,"",null,null);

	public static void Init()
	{
		bossmode = new Modes (0,"",null,null);

	}


}



