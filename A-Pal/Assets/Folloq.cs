using UnityEngine;
using System.Collections;



public class Folloq : MonoBehaviour {

	public Transform Player;
	NavMeshAgent agent;
	Vector3 AgentPosition;
	Vector3 PlayerPosition;
	Vector3 destination;
	public Animator Ani;



	// Use this for initialization
	void Start () 
	{
		agent = GetComponent <NavMeshAgent>();
		destination = agent.destination;
		InvokeRepeating ("goAndStop", 0.5f, 0.5f);
		Ani.enabled = false;
	}
	
	// Update is called once per frame
	void Update () 
	{


	}

	void goAndStop()
	{
		AgentPosition = this.transform.position;
		PlayerPosition = Player.position;
		float Distance = Vector3.Distance (PlayerPosition, AgentPosition);

		if  (Distance > 3.0f) {
			destination = Player.position;
			agent.destination = destination;
			Debug.Log (Distance);


		} else if (Distance < 2f)
		{
			Ani.enabled = true;
			Debug.Log (Distance);

		}

	}
}
