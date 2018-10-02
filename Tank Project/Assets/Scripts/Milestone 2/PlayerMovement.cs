using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	private PlayerHealth data;
	//Allows change of movement and rotation speed
	public float turnSpeed = 90;
	public float moveSpeed = 5;

void Start() {
		data = GetComponent<PlayerHealth> ();
		GameManager.gm.player = this;
}

void Update() {
		float transAmount = moveSpeed * Time.deltaTime;
		float rotateAmount = turnSpeed * Time.deltaTime;

		//Sets buttons for all four movements
		if (Input.GetKey ("w")) {
			transform.Translate (0, 0, transAmount);
		}
		if (Input.GetKey ("s")) {
			transform.Translate (0, 0, -transAmount);
		}
		if (Input.GetKey ("a")) {
			transform.Rotate (0, -rotateAmount, 0);
		}
		if (Input.GetKey ("d")) {
			transform.Rotate (0, rotateAmount, 0);
		}
	}
}