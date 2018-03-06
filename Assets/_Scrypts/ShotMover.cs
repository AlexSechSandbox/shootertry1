using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotMover : MonoBehaviour {

	private Rigidbody shot;
	public float speed = 10f;

	void Start ()
	{
		//rigidbody.velocity = transform.forward * speed;
		shot = GetComponent<Rigidbody> ();
		shot.velocity = transform.forward * speed;
	}
}
