using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puan : MonoBehaviour
{
	// Start is called before the first frame update
	public void OnCollisionEnter2D(Collision2D collision)
	{

		if (collision.gameObject.tag == "Player")
		{ Destroy(gameObject); }
		if (collision.gameObject.tag == "Untagged")
		{ Destroy(gameObject); }
		Debug.Log("+10 PUAN EKLENDİ");
	}
}
