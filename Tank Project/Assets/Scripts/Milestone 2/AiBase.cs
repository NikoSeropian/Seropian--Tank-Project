using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiBase : StateMachineBehaviour {

	public GameObject AiTank;
	public UnityEngine.AI.NavMeshAgent agent;
	public GameObject PlayerTank;
	public float speed = 2.0f;
	public float rotSpeed = 1.0f;
	public float accuracy = 3.0f;

	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		AiTank = animator.gameObject;
		//Tank = AiTank.GetComponent<TankAi>.GetTank();
	}
}
