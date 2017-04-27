using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DominoCollider : MonoBehaviour {

	public GameController gameController;
	public float scoreGap = 2.0f;
	private float nextScore = 0.0f;
	public int levelOneScore = 500;
	public int levelTwoScore = 1000;
	public int levelThreeScore = 2000;
	public int levelFourScore = 4000;
	public int superBonusScore = 1000000;

	private AudioSource audio;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Cow") {
			if (gameObject.tag == "Donovan" && Time.time > nextScore) {
				gameController.AddScore (levelOneScore);
				nextScore = Time.time + scoreGap;
			}
			else if (gameObject.tag == "Devon" && Time.time > nextScore) {
				gameController.AddScore (levelOneScore);
				nextScore = Time.time + scoreGap;
			}
			else if (gameObject.tag == "Dan" && Time.time > nextScore) {
				gameController.AddScore (levelTwoScore);
				nextScore = Time.time + scoreGap;
			}
			else if (gameObject.tag == "Dylan" && Time.time > nextScore) {
				gameController.AddScore (levelTwoScore);
				nextScore = Time.time + scoreGap;
			}
			else if (gameObject.tag == "Phil" && Time.time > nextScore) {
				gameController.AddScore (levelThreeScore);
				nextScore = Time.time + scoreGap;
			}
			else if (gameObject.tag == "Roshawn" && Time.time > nextScore) {
				gameController.AddScore (levelThreeScore);
				nextScore = Time.time + scoreGap;
			}
			else if (gameObject.tag == "Jack" && Time.time > nextScore) {
				gameController.AddScore (levelFourScore);
				nextScore = Time.time + scoreGap;
			}
			else if (gameObject.tag == "Kris" && Time.time > nextScore) {
				gameController.AddScore (superBonusScore);
				nextScore = Time.time + scoreGap;
			}
			audio.Play ();
		}
	}

}
