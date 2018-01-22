using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1AI : CharacterController2D {

	bool goingRight = true;

	void Start () {
		CalculateScreenRestrictions (1.0f);
	}
	
	// Update is called once per frame
	void Update () {
		if (goingRight) {
			Debug.Log ("Going right");
			ApplyHorizontalMovement (speed);
		} else {
			ApplyHorizontalMovement (-speed);
		}
		if (transform.position.x >= maxX) {
			goingRight = false;
		}
		if (transform.position.x <= minX) {
			goingRight = true;
		}
	}
}
