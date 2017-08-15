using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mods {

	public int mod_id;
	public string mod_desc;
	public rotation mod_rot;
	public bulletmove mod_bullet_move;
	//public Dictionary <int mod_id, Mods mod>();


	public Mods(int id)
	{
		mod_id = id;
	}


//	public static Mods Switch(int id)
//	{
//		if (mod_id != id) 
//		{
//			Mods mod = new Mods (id);
//			return mod;
//		}
//	}


}
