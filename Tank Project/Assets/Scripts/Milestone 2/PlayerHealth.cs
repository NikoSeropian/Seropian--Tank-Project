using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

	[HideInInspector]
	public Transform tf;
	[HideInInspector]
	public PlayerMovement controller;

	[Header("Movement")]
	public float moveSpeed;
	public float turnSpeed;

	//Sets tank health data including how much damage it takes
	[Header("Combat")]
	public int maxHealth = 100;
	public int curHealth = 100;
	public int damageTaken = 20;
	public int specialDamageTaken = 80;

	public void Awake () {
		tf = GetComponent<Transform> ();
		controller = GetComponent<PlayerMovement> ();
	}

	//initialization
	void Start () {}

	//Update
	void Update () {
		//Destroys tank when health reaches 0
		if (curHealth < 1) {
			Destroy (gameObject);
		}
	}
	//Makes tank take damage only from colliding with bullets
	void OnCollisionEnter(Collision col) {
		if (col.gameObject.tag == "Bullet") {
			curHealth -= damageTaken;
			Destroy (col.collider);
		} if(col.gameObject.tag == "SpeBullet") {
				curHealth -= specialDamageTaken;
			Destroy (col.collider);
		}
	}
}
