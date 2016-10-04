using UnityEngine;
using System.Collections;



public class Folloq : MonoBehaviour {

	public Transform Player;
	NavMeshAgent agent;
	Vector3 AgentPosition;
	Vector3 PlayerPosition;
	Vector3 destination;



	// Use this for initialization
	void Start () 
	{
		agent = GetComponent <NavMeshAgent>();
		destination = agent.destination;
		InvokeRepeating ("goAndStop", 0.5f, 0.5f);
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

		if  (Distance > 2.5f) {
			destination = Player.position;
			agent.destination = destination;
			Debug.Log (Distance);


		} else if (Distance < 2.5f)
		{
			agent.destination = destination * (-1);
			Debug.Log (Distance);
		}
	}
}
