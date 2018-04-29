using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Controls : MonoBehaviour {

	public static float jetPackFuel = 1.5f;
	public float jetPackForce = 10.0f;
	public int count;

	public Text countText;

	void Start()
	{
		count = 0;
		SetCountText();
	}


	
	void Update () 
	{
		if (Input.GetButton ("Jump") && jetPackFuel >= 0.001f)
		{
			BoostUp ();
		}
	
	}

	void BoostUp()
	{
		jetPackFuel = Mathf.MoveTowards (jetPackFuel, 0, Time.fixedDeltaTime);
		GetComponent<Rigidbody> ().AddForce (new Vector3 (0, jetPackForce));
	}

	void OnCollisionEnter (Collision Col)
	{
		if (Col.gameObject.tag == "Ground")
		{
			jetPackFuel = 1.5f;
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Coin"))
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText();
		}
	}

	void SetCountText()
	{
		countText.text = "Coins: " + count.ToString ();
	}

	
}
