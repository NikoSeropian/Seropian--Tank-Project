using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager gm;
	// Variables
	public float awesomenessLevel = 9000;
	[HideInInspector] public PlayerMovement player;

	// Before any Start
	void Awake () {
		if (gm != null) {
			Destroy (gameObject);
		} else {
			gm = this;
			DontDestroyOnLoad (gameObject);
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SpawnPlayer () {
		//TODO: Do the code to actually spawn the player...
		//TODO: Store the player's InputController in player

	}
}
