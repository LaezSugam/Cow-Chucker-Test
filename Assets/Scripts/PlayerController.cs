using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public GameObject cow;
	public Transform cowSpawn;

	public float fireRate = 0.5f;
	private float nextFire = 0.0f;

	void Update(){


		if (Input.GetButton ("Fire1") && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			Instantiate(cow, cowSpawn.position, cowSpawn.rotation);

		}
	}
}
