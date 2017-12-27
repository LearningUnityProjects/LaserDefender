using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	public GameObject enemy;

	// Use this for initialization
	void Start () {
		Instantiate(enemy, new Vector3(0,0,0), Quaternion.identity, transform);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
