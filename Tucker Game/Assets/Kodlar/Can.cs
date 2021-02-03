using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Can : MonoBehaviour
{
	public void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			if (karakter.can != 2f)
			{ karakter.can += 0.3f; }

			Destroy(gameObject);
		}
		if (collision.gameObject.tag == "Untagged")
		{ Destroy(gameObject); }
	}

}
