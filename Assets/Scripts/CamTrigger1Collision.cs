using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CamTrigger1Collision : MonoBehaviour {

	public Camera cam1;
	public Camera cam2;
	public Camera cam3;
	public Camera cam4;

	private Camera currentCam;

	private List<Camera> cameras = new List<Camera>();

	private Transform camTarget;

	void Start(){
		cameras.Add (cam1);
		cameras.Add (cam2);
		cameras.Add (cam3);
		cameras.Add (cam4);
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Cow") {
			camTarget = other.transform;
			foreach (Camera cam in cameras) {
				cam.enabled = false;
			}
			if (gameObject.name == "CamTrigger1") {
				currentCam = cam2;
			}
			else if (gameObject.name == "CamTrigger2") {
				currentCam = cam3;
			}

			else if (gameObject.name == "CamTrigger3") {
				currentCam = cam4;
			}
			currentCam.enabled = true;
			currentCam.transform.LookAt (camTarget);
		}
	}

	void Update(){
		currentCam.transform.LookAt (camTarget);
	}
}
