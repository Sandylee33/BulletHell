using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (BossModes.bossmode.mode_mov.GetMovement ()*Time.deltaTime, Space.World);
	}
}
