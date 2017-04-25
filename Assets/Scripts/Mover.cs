using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

	private Rigidbody rigidbody;

	public float thrust;

	// Use this for initialization
	void Start () {

		rigidbody = GetComponent<Rigidbody> ();

		rigidbody.AddForce(transform.forward * thrust);
		rigidbody.AddForce (transform.up * thrust *10);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
