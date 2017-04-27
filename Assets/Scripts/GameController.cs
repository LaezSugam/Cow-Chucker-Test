using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public Text scoreText;
	private int score = 0;

	// Use this for initialization
	void Start () {
		scoreText.text = "Score: " + 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AddScore(int points){
		score += points;
		scoreText.text = "Score: " + score;
	}
}
