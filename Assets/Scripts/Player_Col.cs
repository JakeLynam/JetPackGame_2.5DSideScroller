using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Col : MonoBehaviour 
{
	public GameObject restartUI;
	public GameObject jetPack;

	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag == "Enemy")
		{
			PlayerDies();
		}
	}

	void OnTriggerEnter(Collider trig)
	{
		if (trig.gameObject.tag == "Coin")
		{
			//increase score
			//increase coin collection
			//play audio effect

			Destroy (trig.gameObject);
		}
	}

	void PlayerDies()
	{
		Destroy (jetPack);
		restartUI.gameObject.SetActive (true);
		GetComponent<Rigidbody>().isKinematic = true;
		GetComponent<MeshRenderer>().enabled = false;
		GetComponent<Player_Controls>().enabled = false;
		GetComponent<Player_Move> ().enabled = false;
		GetComponent<ParticleSystem> ().Play ();

		//play death audio
		//save score
		//activate UI for resarting game

		//Application.LoadLevel("Level1");
	}

	
	
}
