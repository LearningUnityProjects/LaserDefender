using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipController : CharacterController2D {

	public float speed = 5.0f;

	// Use this for initialization
	void Start () {
		CalculateScreenRestrictions (1.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey (KeyCode.RightArrow)) {
			ApplyHorizontalMovement (speed);
			ApplyScreenRestrictions ();
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			ApplyHorizontalMovement (-speed);
			ApplyScreenRestrictions ();
		}
	}
}
