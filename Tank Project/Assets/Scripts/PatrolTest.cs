using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolTest : MonoBehaviour {

	GameObject AiTank;
	GameObject[] waypoints;
	int currentWP;

	public float accuracy = 3.0f;
	public float rotSpeed = 2.0f;
	public float speed = 1.0f;

	void Awake()
	{
		waypoints = GameObject.FindGameObjectsWithTag ("waypoint");
	}

	// OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	void start () {
		currentWP = 0;
	}

	// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
	void uppdate () {
		if (waypoints.Length == 0) return;
		if(Vector3.Distance(waypoints[currentWP].transform.position,
			AiTank.transform.position) < accuracy)
		{
			currentWP++;
			if(currentWP >= waypoints.Length)
			{
				currentWP = 0;
			}
		}
		//agent.SetDestination (waypoints [currentWP].transform.position);

		//rotate tank towards waypoint
		var direction = waypoints[currentWP].transform.position - AiTank.transform.position;
		AiTank.transform.rotation = Quaternion.Slerp (AiTank.transform.rotation,
			Quaternion.LookRotation (direction), rotSpeed * Time.deltaTime);
		AiTank.transform.Translate (0, 0, Time.deltaTime * speed);
	}
}


