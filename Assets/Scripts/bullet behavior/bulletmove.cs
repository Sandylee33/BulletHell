using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletmove : MonoBehaviour {

	private Rigidbody2D rb2d;
	public int speed;
	// Use this for initialization
	void Start () 
	{
		rb2d = GetComponent<Rigidbody2D> ();
		rb2d.velocity = transform.up * speed * -1;
		}
	
	// Update is called once per frame
	void Update () {
		
	}
}
