using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MoveForward : MonoBehaviour {

	//This allows the changing of speed for objects
	public float maxSpeed = 5f;

	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;

		Vector3 velocity = new Vector3(0, 0, maxSpeed * Time.deltaTime);

		pos += transform.rotation * velocity;

		transform.position = pos;
	}
}
