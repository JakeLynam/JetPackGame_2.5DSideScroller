using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Spawner : MonoBehaviour 
{
	public GameObject[] coins;
	public GameObject enemys;
	public GameObject player;
	private float enemySpawnTimer = 10.0f;
	private float coinSpawnTimer = 7.0f;



	
	
	void Update () 
	{
		coinSpawnTimer -= Time.deltaTime;
		enemySpawnTimer -= Time.deltaTime;
		
		if (coinSpawnTimer < 0.01)
		{
			SpawnCoins();
		}

		if (enemySpawnTimer < 0.01)
		{
			SpawnEnemy();
		}
	}

	void SpawnCoins()
	{
		//spawns coins on random locations on the x and y axis in front of the player
		Instantiate (coins [(Random.Range (0, coins.Length))], new Vector3 (player.transform.position.x + 30, Random.Range (2, 8), 0), Quaternion.identity);
		coinSpawnTimer = Random.Range (1.0f, 3.0f);
	}

	void SpawnEnemy()
	{
		//transforms enemy randomly in scale and then puts the enemy randomly in front of the player on the x,y,z axis

		enemys.transform.localScale = new Vector3(Random.Range (1, 5), Random.Range (1, 5), Random.Range (1, 5));
		Instantiate (enemys, new Vector3 (player.transform.position.x + 20, Random.Range(1, 9), 0), Quaternion.identity);
		enemySpawnTimer = Random.Range (1.0f, 3.0f);
	}
}
