using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehavior : MonoBehaviour {


	//public List<Modes> boss_mods = new List<Modes>();
	public int modes = 2;
	public int previousMode;
	public BulletBehaviorTemplate[] bulletBehaviorTemplates;
	//public Transform E;

	void Awake(){
		bulletBehaviorTemplates = GetComponents<BulletBehaviorTemplate> ();
		foreach (BulletBehaviorTemplate bulletBehavior in bulletBehaviorTemplates) 
		{
			Bullets.Init (bulletBehaviorTemplates.Length, bulletBehavior);
		}
		
		BossModes.Init (2);

	}

	// Use this for initialization
	void Start () {
		



		BossModes.bossmodes[0].mode_rot = new rotation(Vector3.forward);
		BossModes.bossmodes[0].mode_mov = new movement(Vector3.zero);

		BossModes.bossmodes[1].mode_rot = new rotation(Vector3.back);
		BossModes.bossmodes[1].mode_mov = new movement(Vector3.zero);


		for (int i = 0; i < modes; i++) 
		{
			BossModes.bossmodes [i].mode_bullet = Bullets.bullets [i];
		}


		Debug.Log (BossModes.current_bossmode.mode_id);
		//previousMode = BossModes.bossmode.mode_id;

			StartCoroutine (SwitchBossModeByTime (6));
			//StartCoroutine (Acceleration (3));


	}
	
	// Update is called once per frame
	void Update () {
//		Debug.Log ((int)Time.time);
		if (Input.GetKeyDown (KeyCode.A)) {
			
			BossModes.current_bossmode.Switch (BossModes.bossmodes[0]);
			//Debug.Log (BossModes.bossmode.mode_id);

		} else if (Input.GetKeyDown (KeyCode.S)) 
		{
			BossModes.current_bossmode.Switch (BossModes.bossmodes[1]);
		//	Debug.Log (BossModes.bossmode.mode_id);
		}

		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			BossModes.current_bossmode.hitPoints -= 10f;
		}



		if (BossModes.current_bossmode.hitPoints == 0f )
		{
			SwitchToNextMode ();
		}

	}

	void SwitchToNextMode()
	{
		int i = BossModes.current_bossmode.mode_id;
		if (i+1 < modes) 
		{
			BossModes.current_bossmode.Switch (BossModes.bossmodes [i + 1]);
		} 
		else 
		{
			BossModes.current_bossmode.Switch (BossModes.bossmodes [0]);
		}
	}

	IEnumerator SwitchBossModeByTime(int sec)
	{
		
		yield return new WaitForSecondsRealtime (sec);
		while (true) {
			if (BossModes.current_bossmode.hitPoints > 0) { 
				SwitchToNextMode ();
				yield return new WaitForSecondsRealtime (sec);
			}
		}
	}

	IEnumerator Acceleration(int sec)
	{
		yield return new WaitForSecondsRealtime (sec);
		BossModes.current_bossmode.mode_rot.Accelerate ();
	}

}
