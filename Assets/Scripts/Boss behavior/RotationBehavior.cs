using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (BossModes.current_bossmode.mode_rot != null) {
			transform.Rotate (BossModes.current_bossmode.mode_rot.GetRotation ());
		}
	}
}
