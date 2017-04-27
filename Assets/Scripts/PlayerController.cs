using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public GameObject cow;
	public Transform cowSpawn;
	private Transform cowHip;

	public float fireRate = 0.5f;
	private float nextFire = 0.0f;
	private int thrust = 1;
	public int thrustMultiplier = 1;

	public Camera cam1;
	public Camera cam2;
	public Camera cam3;
	public Camera cam4;

	private List<Camera> cameras = new List<Camera>();
	public float cameraChangeRate = 0.5f;
	private float nextCameraChange = 0.0f;
	private int currentCam = 0;


	void Start(){
		cam1.enabled = true;
		cam2.enabled = false;
		cameras.Add (cam1);
		cameras.Add (cam2);
		cameras.Add (cam3);
		cameras.Add (cam4);
	}

	void Update(){


		if (Input.GetButton ("Fire1") && Time.time > nextFire) {
			thrust += thrustMultiplier;

		}
		if (Input.GetButtonUp ("Fire1")) {
			GameObject cowInstance = Instantiate(cow, cowSpawn.position, cowSpawn.rotation);
			cowHip = cowInstance.transform.Find ("Character1_Hips").transform;
			Rigidbody cowRB = cowHip.GetComponent<Rigidbody> ();
			cowRB.AddForce (cowSpawn.transform.forward * thrust);

//			GameObject cowHips = cowInstance.Find ("Character1_Hips") as GameObject;
//			Rigidbody cowRB = cowHips.GetComponent<Rigidbody> ();
//			cowRB.AddForce (cowSpawn.transform.forward * thrust);

			thrust = 1;
		}

		if (Input.GetButton ("Camera") && Time.time > nextCameraChange) {
			cameras [currentCam].enabled = false;
			currentCam++;
			if (currentCam >= cameras.Count) {
				currentCam = 0;
			}
			cameras [currentCam].enabled = true;
			nextCameraChange = Time.time + cameraChangeRate;
		}
			
	}
}
