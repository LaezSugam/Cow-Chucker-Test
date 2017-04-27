using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public GameObject cow;
	public Transform cowSpawn;

	public float fireRate = 0.5f;
	private float nextFire = 0.0f;
	private int thrust = 1;
	public int thrustMultiplier = 1;

	public GameObject cam1;
	public GameObject cam2;


	void Start(){
//		cam1.SetActive = true;
//		cam2.SetActive = false;
	}

	void Update(){


		if (Input.GetButton ("Fire1") && Time.time > nextFire) {
			thrust += thrustMultiplier;

		}
		if (Input.GetButtonUp ("Fire1")) {
			GameObject cowInstance = Instantiate(cow, cowSpawn.position, cowSpawn.rotation);
			Rigidbody cowRB = cowInstance.GetComponent<Rigidbody> ();
			cowRB.AddForce (cowSpawn.transform.forward * thrust);

//			GameObject cowHips = cowInstance.Find ("Character1_Hips") as GameObject;
//			Rigidbody cowRB = cowHips.GetComponent<Rigidbody> ();
//			cowRB.AddForce (cowSpawn.transform.forward * thrust);

			thrust = 1;
		}
	}
}
