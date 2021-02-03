﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuanSpawner : MonoBehaviour
{
	public GameObject enemy;
	float randX;
	Vector2 whereToSpawn;
	public float spawnRate = 2f;
	float nextSpawn = 0.0f;
	void Start()
	{
		spawnRate = 0.9f;
	}

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
			spawnRate = 0.9f;
		}
		if ((karakter.skor >= 50) && (karakter.skor <= 130))
		{ spawnRate = 0.8f; }
		if ((karakter.skor >= 130) && (karakter.skor <= 200))
		{ spawnRate = 0.7f; }
		if ((karakter.skor >= 200) && (karakter.skor <= 250))
		{ spawnRate = 0.6f; }
		if (karakter.skor >= 1000)
		{ spawnRate = 0.2f; }
		if (karakter.skor >= 2000)
		{ spawnRate = 0.3f; }
	}
}
