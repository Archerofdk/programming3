using UnityEngine;
using System.Collections;

public class Mechanics : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		CheckAhead ();
	}
		


	private void CheckAhead()
	{
		//Cast a ray from the middle of the screen
		Ray ray = Camera.main.ViewportPointToRay (new Vector3(0.5F,0.5F,0));
		RaycastHit rayCast;


		if (Physics.Raycast(ray, out rayCast,1)) 
		{
			
			if (rayCast.collider.tag == "Crate")
			{
				//instructions ();
				//If e is pressed, the crate can be moved
				if (Input.GetKey ("e")) 
				{
					GameObject.Find ("Crate").GetComponent<Move> ().move = true;


				}
				else
				{
					GameObject.Find ("Crate").GetComponent<Move> ().move = false;
				}

			}



		} else 
		{
			GameObject.Find ("Crate").GetComponent<Move> ().move = false;
			//updateText ();
		}
	}

}
