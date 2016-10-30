using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class Mechanics : MonoBehaviour 
{
	public Text pressE;
	public Text pressEnumber;
	GameObject Crate;
	public Transform pos1;
	public Transform pos3;
	public Transform pos4;
	public Transform pos7;
	public GameObject Number7Pre;
	public GameObject Number4Pre;
	public GameObject Number3Pre;
	public GameObject Number1Pre;
	bool paused = false;
	bool number7 = false;
	bool number4 = false;
	bool number3 = false;
	bool number1 = false;

	// Use this for initialization
	void Start ()
	{
		//Find the crate
		Crate = GameObject.Find ("Crate");

	}
	// Update is called once per frame
	void Update () 
	{
		//Run these
		CheckAhead ();
		inventory ();

	}
		


	private void CheckAhead()
	{
		//Cast a ray from the middle of the screen
		Ray ray = Camera.main.ViewportPointToRay (new Vector3(0.5F,0.5F,0));
		RaycastHit rayCast;

		//if the the ray hits something
		if (Physics.Raycast(ray, out rayCast,1)) 
		{
			//and if that something has the tag crate
			if (rayCast.collider.tag == "Crate")
			{
				//Run instructions
				instructions ();
				//If e is pressed, the crate can be moved
				if (Input.GetKey ("e")) 
				{
					//Set move on the Crate script to true so the crate is moved
					Crate.GetComponent<Move> ().move = true;


				}

				else
				{
					//If e isn't pressed, set it to false
					Crate.GetComponent<Move> ().move = false;
				}

			}
			if (rayCast.collider.tag == "number7") 
			{
				if (Input.GetKey ("e")) 
				{
					number7 = true;
					instructions2 ();
					Destroy (GameObject.Find ("Number 7"));
					StartCoroutine (update ());
				}

			}
			if (rayCast.collider.tag == "number4") 
			{
				if (Input.GetKey ("e")) 
				{
					number4 = true;
					instructions2 ();
					Destroy (GameObject.Find ("Number 4"));
					StartCoroutine (update ());
				}
			}
			if (rayCast.collider.tag == "number3") 
			{
				if (Input.GetKey ("e")) 
				{
					number3 = true;
					instructions2 ();
					Destroy (GameObject.Find ("Number 3"));
					StartCoroutine (update ());
				}
			}
			if (rayCast.collider.tag == "number1") 
			{
				if (Input.GetKey ("e")) 
				{
					number1 = true;
					instructions2 ();
					Destroy (GameObject.Find ("Number 1"));
					StartCoroutine (update ());
				}
			}




		} else 
		{
			//If ray does not his anything, set to false and update the text so it does not say instructions anymore
			Crate.GetComponent<Move> ().move = false;
			updateText ();
		}
	}


	private void inventory ()
	{
		//if i is pressed
		if (Input.GetKeyDown ("i") && !paused) 
		{
			//and if any of the numbers have been found
			if (number1 || number3 || number4 || number7) 
			{
				//disable the controls
				GetComponent <FirstPersonController> ().enabled = false;
				paused = true;


			}


			//if a number has been found
			if (number1) 
			{
				//instanciate the number prefab in front of camera
				Instantiate (Number1Pre, pos1.position, pos1.rotation);

			}
			if (number3) 
			{
				//instanciate the number prefab in front of camera
				Instantiate (Number3Pre, pos3.position, pos3.rotation);

			}
			if (number4) 
			{
				//instanciate the number prefab in front of camera
				Instantiate (Number4Pre, pos4.position, pos4.rotation);

			}
			if (number7) 
			{
				//instanciate the number prefab in front of camera
				Instantiate (Number7Pre, pos7.position, pos7.rotation);

			}
				
		}
		//If i is pressed again
		else if (Input.GetKeyDown ("i") && paused) 
		{
			//enable control
			GetComponent <FirstPersonController> ().enabled = true;
			paused = false;

			//If the number1 prefab is on the screen
			if (number1)
			{
				//Destroy it
				Destroy (GameObject.Find ("Number 1(Clone)"));
			}
			if (number3)
			{
				//Destroy it
				Destroy (GameObject.Find ("Number 3(Clone)"));
			}
			if (number4)
			{
				//Destroy it
				Destroy (GameObject.Find ("Number 4(Clone)"));
			}
			if (number7)
			{
				//Destroy it
				Destroy (GameObject.Find ("Number 7(Clone)"));
			}
		}

	}


	//Shows text on screen when called.
	private void instructions ()
	{
		pressE.text = "press e to push crate";
	}

	private void instructions2 ()
	{
		pressEnumber.text = "press i to see gathered numbers";
	}
	private void updateText ()
	{
		
		pressE.text = " ";

	}
	//A way to wait so the text doesn't dissapear instantly
	IEnumerator update ()
	{
		yield return new WaitForSecondsRealtime (2);
		pressEnumber.text = " ";
	}

}
