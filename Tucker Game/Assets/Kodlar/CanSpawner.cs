using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanSpawner : MonoBehaviour
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
		{ Destroy(gameObject); }
		if (karakter.can <= 0.7f)
		{
			spawnRate = 0.90f;
			Debug.Log("CAN<=0.7f spawnRate Arttırılmıştır.");
		}
		else
		{
			spawnRate = 3f;
			Debug.Log("CAN>=0.8f spawnRate Düşürülmüştür.");
		}
	}


}
