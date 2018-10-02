using UnityEngine;
using System.Collections;

public class AiShooting : MonoBehaviour {
	//this is mostly a duplicate of PlayerShooting script
	//offset of bullet spawn from tank
	public Vector3 AibulletOffset = new Vector3(0, 0.5f, 0);

	public GameObject AibulletPrefab;
	int AibulletLayer;

	//sets time between shots
	public float fireDelay = 0.25f;
	float cooldownTimer = 0;

	void Start() {
		AibulletLayer = gameObject.layer;
	}

	// Update is called once per frame
	void Update () {
		//Makes it so tank doesn't fire until delay is over. Removed requirement of button press for AI.
		cooldownTimer -= Time.deltaTime;

		if( cooldownTimer <= 0 ) {
			cooldownTimer = fireDelay;

			//launches shell from offset location
			Vector3 offset = transform.rotation * AibulletOffset;

			GameObject AibulletGO = (GameObject)Instantiate(AibulletPrefab, transform.position + offset, transform.rotation);
			AibulletGO.layer = AibulletLayer;
		}
	}
}
