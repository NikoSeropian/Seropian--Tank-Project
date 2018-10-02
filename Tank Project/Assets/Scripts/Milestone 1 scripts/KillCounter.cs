using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillCounter : MonoBehaviour {
	public int kills = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnDestroy() {
		kills = +1;
	}
}
