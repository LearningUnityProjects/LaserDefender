using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicLaser : CharacterController2D {

	public float bulletLifeTime = 2.0f;

	// Update is called once per frame
	void Update () {
		ApplyVerticalMovement (speed);
		Invoke ("Die", bulletLifeTime);
	}

	void Die() {
		gameObject.SetActive(false);
 	}
}
