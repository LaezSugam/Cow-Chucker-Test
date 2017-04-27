using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour {

	private Rigidbody rigidbody;

	// Use this for initialization
	void Start () {

		rigidbody = GetComponent<Rigidbody> ();
		
	}

	void FixedUpdate () {		
//		if(Input.GetAxis("Horizontal") != 0)
//		{
//			transform.Rotate ((Vector3.forward * Input.GetAxis ("Horizontal")) * Time.deltaTime * 100);		
//		}

//		if (Input.GetAxis ("Vertical") < 0) {
//			transform.Rotate (new Vector3(1,0,0));
//			transform.rotation = Quaternion.Euler (transform.eulerAngles.x, transform.eulerAngles.y, 0);
//		}
//
//		if (Input.GetAxis ("Vertical") > 0) {
//			transform.Rotate (new Vector3(-1,0,0));
//			transform.rotation = Quaternion.Euler (transform.eulerAngles.x, transform.eulerAngles.y, 0);
//		}
//
//		if (Input.GetAxis ("Horizontal") > 0) {
//			transform.Rotate (new Vector3(0,1,0));
//			transform.rotation = Quaternion.Euler (transform.eulerAngles.x, transform.eulerAngles.y, 0);
//		}
//
//		if (Input.GetAxis ("Horizontal") < 0) {
//			transform.Rotate (new Vector3(0,-1,0));
//			transform.rotation = Quaternion.Euler (transform.eulerAngles.x, transform.eulerAngles.y, 0);
//		}

		transform.Rotate (new Vector3(0, Input.GetAxis ("Horizontal"),0));
		transform.Rotate (new Vector3(Input.GetAxis ("Vertical"),0,0));
		transform.rotation = Quaternion.Euler (transform.eulerAngles.x, transform.eulerAngles.y, 0);
	}
}
