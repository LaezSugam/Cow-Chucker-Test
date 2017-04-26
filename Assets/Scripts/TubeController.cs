using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeController : MonoBehaviour {

	private Rigidbody rigidbody;
	public Transform canonBase;

	// Use this for initialization
	void Start () {

		rigidbody = GetComponent<Rigidbody> ();

	}

	void FixedUpdate () {
		if (Input.GetAxis ("Vertical") < 0) {
			transform.RotateAround (canonBase.position, new Vector3(1,0,0), 1);
		}

		if (Input.GetAxis ("Vertical") > 0) {
			transform.RotateAround (canonBase.position, new Vector3(1,0,0), -1);
		}


	}
}
