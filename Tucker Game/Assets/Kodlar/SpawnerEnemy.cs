using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnemy : MonoBehaviour
{
	public GameObject enemy;
	float randX;
	Vector2 whereToSpawn;
	public float spawnRate = 2f;
	float nextSpawn = 0.0f;
	
	public void FixedUpdate()
	{
		if (Time.time > nextSpawn)
		{

			nextSpawn = Time.time + spawnRate;

			randX = Random.Range(-17f, 17f);

			whereToSpawn = new Vector2(randX, transform.position.y);

			Instantiate(enemy, whereToSpawn, Quaternion.identity);

		}
		if (karakter.can <= 0f)
		{
			Destroy(gameObject);
			spawnRate = 2f;
		}
		if ((karakter.skor >= 50) && (karakter.skor <= 130))
		{ spawnRate = 0.8f; }
		if ((karakter.skor >= 130) && (karakter.skor <= 220))
		{ spawnRate = 0.7f; }
		if ((karakter.skor >= 220) && (karakter.skor <= 300))
		{ spawnRate = 0.6f; }
		if ((karakter.skor >= 220) && (karakter.skor <= 300))
		{ spawnRate = 0.6f; }
		if ((karakter.skor >= 300) && (karakter.skor <= 500))
		{ spawnRate = 0.5f; }
		if ((karakter.skor >= 500) && (karakter.skor <= 700))
		{ spawnRate = 0.4f; }
		if (karakter.skor >= 1000)
		{ spawnRate = 0.2f; }

	}



}
