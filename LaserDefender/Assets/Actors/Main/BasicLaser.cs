using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicLaser : CharacterController2D {

	public float bulletLifeTime = 2.0f;
	public float laserSpeed = 5.0f;

	// Update is called once per frame
	void Update () {
		ApplyVerticalMovement (laserSpeed);
		Invoke ("Die", bulletLifeTime);
	}

	void Die() {
		gameObject.SetActive(false);
 	}
}
