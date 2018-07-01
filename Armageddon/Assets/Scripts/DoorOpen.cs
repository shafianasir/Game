using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour {

	private Animator animation;

	// Use this for initialization
	void Start () {
		animation = GetComponent<Animator> ();
	}

	void OnTriggerEnter(Collider collide){
		if (collide.tag == "Player") {
			animation.SetBool ("Open", true);
		}
	}
}
