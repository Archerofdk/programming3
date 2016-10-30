using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour 
{
	float moveSpeed = 1;
	public bool move;


	// Use this for initialization
	void Start () 
	{
		//InvokeRepeating ("MoveBox", 0.5f, 0.5f);

	}
	
	// Update is called once per frame
	void Update () 
	{
		//run this
		MoveBox ();

	}


	void MoveBox ()
	{
		//Find the player
		GameObject Player = GameObject.Find ("FPSController");
		if (move)
		{
			//Get the vector between this object and the player
			Vector3 my_push = transform.position - Player.transform.position;

			//Make sure it doesn't go up or down
			my_push.y = 0;

			//if the player isn't too far away
			if (my_push.magnitude < 2)
			{
				//move the object in the direction given by the vector above
				transform.position += my_push.normalized * moveSpeed * Time.deltaTime;
			}

		}

	}
}
