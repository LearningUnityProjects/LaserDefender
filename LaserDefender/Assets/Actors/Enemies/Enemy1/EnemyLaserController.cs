using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaserController : MonoBehaviour {
	public float reloadDelay = 0.5f;

	private bool canFire = false;

	// Use this for initialization
	void Start () {
		Invoke ("EnableFire", reloadDelay);
	}

	void FixedUpdate () {
		if (canFire) {
			EnemyAmmoManager.SpawnAmmo (transform.position, transform.rotation);
			canFire = false;
			Invoke ("EnableFire", reloadDelay);
		}
	}

	void EnableFire()
	{
		canFire = true;
	}
}
