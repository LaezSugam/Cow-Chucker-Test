using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public GameObject cow;
	public Transform cowSpawn;

	void Update(){


		if (Input.GetButton ("Fire1")) {
			//GameObject clone = 
			Instantiate(cow, cowSpawn.position, cowSpawn.rotation);// as GameObject;

		}
	}
}
