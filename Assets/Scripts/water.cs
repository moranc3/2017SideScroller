﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D (Collider2D collision)

	{
		var player = collision.gameObject.GetComponent<player>():
			if player != null) {
				player.canfly = true;
}

