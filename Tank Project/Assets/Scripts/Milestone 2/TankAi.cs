using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAi : MonoBehaviour {

	Animator anim;
	public GameObject Tank;

	public GameObject GetTank()
	{
		return Tank;
	}

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		anim.SetFloat ("distance", Vector3.Distance (transform.position, Tank.transform.position));

	}
}
