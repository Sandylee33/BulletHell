using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {

	public GameObject shots2;
	public Transform gun;
	private float nextFire;
	public float fireRate;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			Instantiate (shots2, gun.position, gun.rotation);
		}

	}
}
