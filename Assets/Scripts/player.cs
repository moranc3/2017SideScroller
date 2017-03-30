﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

	public int health = 100;
	public float speed = 5;
	public float jumpSpeed = 5;
	public float deadZone = -4;

	new Rigidbody2D rigidbody; 
	GM _GM; 


	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody2D> ();
		_GM = FindObjectOfType<GM> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		// Apply Movement
		float x = Input.GetAxisRaw ("Horizontal");
		Vector2 v = rigidbody.velocity;
		v.x = x * speed;

		if (Input.GetButtonDown ("Jump")) {
			v.y = jumpSpeed;
		}

		rigidbody.velocity = v;

		if (transform.position.y < deadZone) {
			Debug.Log ("You're Out");
		}


		//rigidbody.velocity = new Vector2 (x * speed , rigidbody.velocity.y);


		//rigidbody.AddForce (new Vector2 (x * speed, 0));
	}

	public void GetOut() {
		_GM.SetLives (_GM.lives - 1);
	}
}
