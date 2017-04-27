using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CamTrigger1Collision : MonoBehaviour {

	public Camera cam1;
	public Camera cam2;

	private List<Camera> cameras = new List<Camera>();

	private Transform cam2Target;

	void Start(){
		cameras.Add (cam1);
		cameras.Add (cam2);
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Cow") {
			cam2Target = other.transform;
			foreach (Camera cam in cameras) {
				cam.enabled = false;
			}
			cam2.enabled = true;
			cam2.transform.LookAt (cam2Target);
		}
	}

	void Update(){
		cam2.transform.LookAt (cam2Target);
	}
}
