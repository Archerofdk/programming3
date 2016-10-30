using UnityEngine;
using System.Collections;



public class Folloq : MonoBehaviour {

	public Transform Player;
	NavMeshAgent agent;
	Vector3 AgentPosition;
	Vector3 PlayerPosition;
	Vector3 destination;
	public Animator Ani;
	public bool Collided = false;


	// Use this for initialization
	void Start () 
	{
		agent = GetComponent <NavMeshAgent>();
		destination = agent.destination;

	}
	
	// Update is called once per frame
	void Update () 
	{
		//run this
		goAndStop ();

	}
		

	void goAndStop()
	{
		//Find the position of everything.
		AgentPosition = this.transform.position;
		PlayerPosition = Player.position;
		float Distance = Vector3.Distance (PlayerPosition, AgentPosition);
		//print (direction);

		//Set destination to player position
		agent.destination = PlayerPosition;

		 
		//if the player gets too close to A-Pal
		if (Distance < 3f) 
		{
			//rotate around the player
			transform.RotateAround (PlayerPosition,Vector3.up, 70* Time.deltaTime);
			//push away from from the player
			transform.position -= (PlayerPosition - AgentPosition) * Time.deltaTime;

		}

			
	}
}
