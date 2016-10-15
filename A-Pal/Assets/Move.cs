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
		MoveBox ();

	}


	void MoveBox ()
	{
		GameObject Player = GameObject.Find ("FPSController");
		if (move)
		{
			//Get the vector between this object and the player
			Vector3 my_forward = transform.position - Player.transform.position;
			//Debug.Log (my_forward);
			//Make sure it doesn't go up or down
			my_forward.y = 0;

			if (my_forward.magnitude < 2)
			{
				//move the object in the direction given by the vector above
				transform.position += my_forward.normalized * moveSpeed * Time.deltaTime;
			}

		}

	}

	/*void OnCollisionEnter (Collision other)
	{
		noMore = false;
	}*/
}
