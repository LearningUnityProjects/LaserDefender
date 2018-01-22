using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour {

	public string laserTag = "Laser";
	public int score = 25;
	public AudioClip explosion;

	private float destroyDelay = 0.2f;

	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag == laserTag) {
			LaserDamage damage = coll.gameObject.GetComponent<LaserDamage> ();
			Health health = gameObject.GetComponent<Health> ();
			if (damage && health) {
				health.healthPoints -= damage.damagePoints;
				if (health.healthPoints <= 0) {
					AudioSource.PlayClipAtPoint (explosion, transform.position);
					Destroy (gameObject);
					ScoreManager.getInstance().addScore (score);
				}
			}
			Destroy (coll.gameObject);
		}
	}
}
