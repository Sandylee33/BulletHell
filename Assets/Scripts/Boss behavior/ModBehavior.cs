using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mod : MonoBehaviour {



	// Use this for initialization
	void Start () {
		List<Mods> mods = new List<Mods> ();
		for (int i = 0; i < 2; i++) {
			Mods mod = new Mods (i);
			mods.Add (mod);
		}

		mods[1].mod_desc = "single rotation";
		mods[1].mod_rot = null;
		mods[1].mod_bullet_move = null;

		mods[2].mod_desc = "double rotation";
		mods[2].mod_rot = null;
		mods[2].mod_bullet_move = null;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
