using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	public GameObject enemy;
	public float spawnDelay = 0.5f;

	// Use this for initialization
	void Start () {
		SpawnEnemies ();
	}
	
	// Update is called once per frame
	void Update () {
		if (AllEnemiesAreDead ()) {
			SpawnEnemies ();
		}
	}

	bool AllEnemiesAreDead() {
		foreach (Transform child in transform) {
			if (child.childCount > 0) {
				return false;
			}
		}
		return true;
	}

	void SpawnEnemies() {
		Transform freeTransform = NextFreeTransform ();
		if (freeTransform) {
			Instantiate (enemy, freeTransform.position, Quaternion.identity, freeTransform);
		}
		if (NextFreeTransform ()) {
			Invoke ("SpawnEnemies", spawnDelay);
		}
	}

	Transform NextFreeTransform() {
		foreach (Transform child in transform) {
			if (child.childCount == 0) {
				return child;
			}
		}
		return null;
	}
		
}
