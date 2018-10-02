using UnityEngine;
using System.Collections;

public class SelfDestruct : MonoBehaviour {


	//Puts timer on object
	public float timer = 1f;

	void Update () {
		timer -= Time.deltaTime;
		//Destroys object after time runs out
		if (timer <= 0) {
			Destroy (gameObject);
		}
	}
		void onCollisionEnter (Collision other) {
		if (other.gameObject.CompareTag ("Enemy")) {
			Destroy (gameObject);
		}

		}

	}	
		//void OnCollisionEnter(Collision col) {
			//if (col.gameObject){
			//Destroy (col.collider);
		//}
	//}

