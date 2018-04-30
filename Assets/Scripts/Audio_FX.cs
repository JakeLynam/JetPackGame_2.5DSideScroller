using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_FX : MonoBehaviour 
{
	public AudioClip death, jetPack, coinCollect;

	void Update () 
	{
		if (Input.GetButton ("Jump") && Player_Controls.jetPackFuel >= 0.001f)
		{
			GetComponent<AudioSource> ().PlayOneShot (jetPack, 1.0f);
		}
	}

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "Enemy")
		{
			GetComponent<AudioSource> ().PlayOneShot (death, 1.0f);
		}
	}

	void OnTriggerEnter (Collider trig)
	{
		if (trig.gameObject.tag == "Coin")
		{
			GetComponent<AudioSource> ().PlayOneShot (coinCollect, 1.0f);
		}
	}
}
