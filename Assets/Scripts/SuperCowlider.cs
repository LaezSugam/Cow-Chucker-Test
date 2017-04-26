using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperCowlider : MonoBehaviour {

	private Rigidbody rigidbody;
	private GameObject other;

	// Use this for initialization
	void Start () {

		rigidbody = GetComponent<Rigidbody> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision col){
		
	}
}
