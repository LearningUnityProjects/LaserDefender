using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public static ScoreManager singleton = null;

	public string initialScore = "0";

	private Text scoreText;

	void Awake () {
		if (singleton != null) {
			Destroy (GetComponent<ScoreManager> ());
			return;
		}
		singleton = this;
		scoreText = GameObject.Find ("Score").GetComponent<Text> ();
		scoreText.text = initialScore;
	}

	public static ScoreManager getInstance() {
		return singleton;
	}

	public void addScore(int sumToScore) {
		int scoreUpdated = int.Parse (scoreText.text);
		scoreUpdated += sumToScore;
		scoreText.text = scoreUpdated.ToString();
	}

}
