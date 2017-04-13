using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour {
	public int _Points;

	void OnCollisionEnter2D(Collision2D coll)
	{
		var player = coll.gameObject.GetComponent<player> ();
		if (player != null) {
			gameObject.SetActive (false);
			FindObjectOfType<GM> ().setPoints (FindObjectOfType<GM>().GetPoints() + 1);
		}
		
	}
}
