using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {

	//Offset of bullet spawn from tank
	public Vector3 bulletOffset = new Vector3(0, 0.5f, 0);

	public GameObject bulletPrefab;
	int bulletLayer;

	//Time after shooting until tank can fire again
	public float fireDelay = 0.25f;
	float cooldownTimer = 0;

	void Start() {
		bulletLayer = gameObject.layer;
	}

	// Update is called once per frame
	void Update () {
		cooldownTimer -= Time.deltaTime;

		//requires both delay to be over and player to press space in order to fire
		if( Input.GetKeyDown(KeyCode.Space) && cooldownTimer <= 0 ) {
			cooldownTimer = fireDelay;

			//Launches shell from offset location
			Vector3 offset = transform.rotation * bulletOffset;

			GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
			bulletGO.layer = bulletLayer;
		}
	}
}
