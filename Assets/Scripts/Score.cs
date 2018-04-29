using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour 
{
	public Transform player;
	public Text scoreText;

	public int currentScore;
	public int highScore;
	public int coinsCollected;

	
	// Update is called once per frame
	void Update () 
	{
		//distance traveled represented as whole numbers when you include "0" in the parenthesis
		scoreText.text = player.position.x.ToString("Distance: 0");

		
	}
}
