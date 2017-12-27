using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	public GameObject enemy;

	// Use this for initialization
	void Start () {
		foreach (Transform child in transform) {
			Instantiate(enemy, child.position, Quaternion.identity, child);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
