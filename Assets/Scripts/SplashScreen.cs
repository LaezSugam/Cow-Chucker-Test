using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine ("Countdown");	
	}

	private IEnumerator Countdown(){
		yield return new WaitForSeconds (6.5f);
		SceneManager.LoadScene (1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
