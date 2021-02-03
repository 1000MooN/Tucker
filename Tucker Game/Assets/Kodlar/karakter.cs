using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using System.Resources;
using UnityEngine.SceneManagement;

public class karakter : MonoBehaviour
{

	public static float can;
	Rigidbody2D çar;
	float dirX, dirY;
	[Range(1f, 20f)]
	public float moveSpeed = 15f;
	public Text puan;
	public static float skor = 0f;
	private Material matWhite;
	private Material matDefault;
	SpriteRenderer sr;
	SpriteRenderer ase;

	void Start()
	{
		skor = 0;
		çar = GetComponent<Rigidbody2D>();
		can = 2f;
		sr = GetComponent<SpriteRenderer>();
		ase = GetComponent<SpriteRenderer>();
		matWhite = Resources.Load("WhiteFlash", typeof(Material)) as Material;
		matDefault = sr.material;
	}
	private void Update()
	{
		if (Time.timeScale == 1f)
		{
			skor += Time.deltaTime;
			puan.text = "PUAN " + skor.ToString("#");
		}

	}

	private void FixedUpdate()
	{
		dirX =Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
		transform.position = new Vector2(transform.position.x + dirX, transform.position.y + dirY);

		if (can <= 0f)
		{
			Destroy(gameObject);
			//SceneManager.LoadScene(0);
		}

		ase.material = matDefault;

		if ((can >= 2f) && (can >= 2.3f) && (can <= 2.6f))
		{ can = 2f; }

	}
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "meteor")
		{
			can -= 0.20f;
			sr.material = matWhite;
		}

		//puan.text = "PUAN " + skor.ToString("#");

		if (collision.gameObject.tag == "PUAN")
		{
			skor = skor + 10f;
		}
		if (collision.gameObject.tag == "HIZ")
		{
			moveSpeed = 25f;
			if (collision.gameObject.tag == "meteor")
			{ moveSpeed = 15f; }
		}

	}

}

