using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2D : MonoBehaviour {

	float minX;
	float maxX;

	public void CalculateScreenRestrictions (float padding) {
		float distance = transform.position.z - Camera.main.transform.position.z;
		minX = Camera.main.ViewportToWorldPoint (new Vector3 (0, 0, distance)).x;
		maxX = Camera.main.ViewportToWorldPoint (new Vector3 (1, 0, distance)).x;
		minX += padding;
		maxX -= padding;
	}

	public void ApplyHorizontalMovement(float speed) {
		transform.position += new Vector3 (speed * Time.deltaTime, 0, 0);
	}

	public void ApplyScreenRestrictions() {
		float clampedX = Mathf.Clamp (transform.position.x, minX, maxX);
		transform.position = new Vector3 (clampedX, transform.position.y, transform.position.z);
	}
}
