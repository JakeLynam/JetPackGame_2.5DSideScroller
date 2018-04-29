using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Col : MonoBehaviour 
{
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
		//play death audio
		//save score
		//activate UI for resarting game

		Application.LoadLevel("Level1");
	}

	
	
}
