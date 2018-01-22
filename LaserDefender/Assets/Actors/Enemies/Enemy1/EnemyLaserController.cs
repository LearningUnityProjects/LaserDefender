using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaserController : MonoBehaviour {
	public float reloadDelay = 0.5f;
	public AudioClip laserAudio;

	private bool canFire = false;

	// Use this for initialization
	void Start () {
		Invoke ("EnableFire", reloadDelay);
	}

	void FixedUpdate () {
		if (canFire) {
			AudioSource.PlayClipAtPoint (laserAudio, transform.position);
			EnemyAmmoManager.SpawnAmmo (transform.position, transform.rotation);
			canFire = false;
			Invoke ("EnableFire", Random.Range(-0.5f, 1.0f) + reloadDelay);
		}
	}

	void EnableFire()
	{
		canFire = true;
	}
}
