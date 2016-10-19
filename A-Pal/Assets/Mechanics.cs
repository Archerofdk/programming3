using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Mechanics : MonoBehaviour 
{
	public Text pressE;
	GameObject Crate;

	// Use this for initialization
	void Start () 
	{
		Crate = GameObject.Find ("Crate");
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
				instructions ();
				//If e is pressed, the crate can be moved
				if (Input.GetKey ("e")) 
				{
					Crate.GetComponent<Move> ().move = true;


				}
				else
				{
					Crate.GetComponent<Move> ().move = false;
				}

			}



		} else 
		{
			Crate.GetComponent<Move> ().move = false;
			updateText ();
		}
	}

	private void instructions ()
	{
		pressE.text = "press e to push crate";
	}
	private void updateText ()
	{
		pressE.text = " ";
	}

}
