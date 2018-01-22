using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserController : MonoBehaviour {

	public AudioClip laserAudio;
	public float reloadDelay = 0.5f;

	private bool canFire = true;

	// Use this for initialization
	void Start () {
		
	}
	
	void FixedUpdate () {
		if (Input.GetKey (KeyCode.Space) && canFire) {
			AudioSource.PlayClipAtPoint (laserAudio, transform.position);
			AmmoManager.SpawnAmmo (transform.position, transform.rotation);
			canFire = false;
			Invoke ("EnableFire", reloadDelay);
		}
	}

	void EnableFire()
	{
		canFire = true;
	}
}
