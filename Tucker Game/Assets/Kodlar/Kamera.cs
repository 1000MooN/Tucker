using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour
{
	public Transform hedef;
	public Transform oyunbitince;
	public float hız = 1f;
	public Camera kamera;
	private void Start()
	{
		
	}
	void Update()
	{
		if (karakter.can > 0f)
		{
			transform.LookAt(hedef);

			transform.Rotate(new Vector3(-10, 0, 0), Space.Self);
		}

	
		else if (karakter.can <= 0f)
		{
			transform.LookAt(oyunbitince);
			transform.Rotate(new Vector3(0, 0, 0), Space.Self);
		}

	}

	public void OnCollisionEnter2D(Collision2D collision)
	{

		if(collision.gameObject.tag=="meteor")
		{
		
		}

	}
	public void OnCollisionExit2D(Collision2D collision)
	{
		
			
		
	}
}
