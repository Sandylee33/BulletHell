using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehavior : MonoBehaviour {

	public List<Modes> boss_mods = new List<Modes>();

	public int modes = 2;
	public int previousMode;

	//public Transform E;

	// Use this for initialization
	void Start () {
	//	E = GetComponentInParent<Transform> ();
		for (int i = 0; i < modes; i++) 
		{
			boss_mods.Add (new Modes (i,"",null,null));
		}
		boss_mods [0].mode_rot = new rotation(Vector3.forward);
		boss_mods [0].mode_mov = new movement(Vector3.right);
		boss_mods [1].mode_rot = new rotation(Vector3.back);
		boss_mods [1].mode_mov = new movement(Vector3.down);
		BossModes.Init ();
		previousMode = BossModes.bossmode.mode_id;
		StartCoroutine (SwitchBossModeByTime (5));
		StartCoroutine (Acceleration (10));

	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ((int)Time.time);
		if (Input.GetKeyDown (KeyCode.A)) {
			
			BossModes.bossmode.Switch (boss_mods[0]);
			Debug.Log (BossModes.bossmode.mode_id);

		} else if (Input.GetKeyDown (KeyCode.S)) 
		{
			BossModes.bossmode.Switch (boss_mods[1]);
			Debug.Log (BossModes.bossmode.mode_id);
		}

		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			BossModes.bossmode.hitPoints -= 10f;
		}



		if (BossModes.bossmode.hitPoints == 0f )
		{
			SwitchToNextMode ();
		}

	}

	void SwitchToNextMode()
	{
		int i = BossModes.bossmode.mode_id;
		if (i+1 < modes) 
		{
			BossModes.bossmode.Switch (boss_mods [i + 1]);
		} 
		else 
		{
			BossModes.bossmode.end = true;
		}
	}

	IEnumerator SwitchBossModeByTime(int sec)
	{
		
		yield return new WaitForSecondsRealtime (sec);
		if (BossModes.bossmode.hitPoints > 0) 
		{ 
			SwitchToNextMode ();
		}
	}

	IEnumerator Acceleration(int sec)
	{
		yield return new WaitForSecondsRealtime (sec);
		BossModes.bossmode.mode_rot.Accelerate ();
	}

}
