using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2D : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

	public void ApplyHorizontalMovement(float speed) {
		transform.position += new Vector3 (speed * Time.deltaTime, 0, 0);
	}
}
