using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (BossModes.bossmode.mode_mov != null) {
			transform.Translate (BossModes.bossmode.mode_mov.GetMovement () * Time.deltaTime, Space.World);
		}
	}
}
