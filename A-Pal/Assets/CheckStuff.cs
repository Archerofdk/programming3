using UnityEngine;
using System.Collections;

public class CheckStuff : MonoBehaviour 
{
	

	//When the player entered
	void OnTriggerEnter (Collider other)
	{
		//Find the script and change the bool
		GameObject.Find ("Follow").GetComponent<Folloq> ().Collided = true;

	}
}
