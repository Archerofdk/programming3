using UnityEngine;
using System.Collections;

public class HasHp : MonoBehaviour {
	
	public float hitPoints = 1f;
	public AudioClip StarCaught;

	public void ReceiveDamage (float amt)
	{
		hitPoints -= amt;
		if (hitPoints <= 0)
		{
			Die();
		}
	}
	void Die ()
	{
		//Accesses public class WhoSpawns
		AudioSource.PlayClipAtPoint (StarCaught, transform.position);
		Destroy (gameObject);

	}
}

