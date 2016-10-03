using UnityEngine;
using System.Collections;



public class Folloq : MonoBehaviour {

	public Transform Player;
	NavMeshAgent agent;
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
		PlayerPosition = Player.position;
		 
		if (Vector3.Distance (destination, PlayerPosition)>1.0f)
		{
			destination = PlayerPosition;
			agent.destination = destination;
		}
	}
}
