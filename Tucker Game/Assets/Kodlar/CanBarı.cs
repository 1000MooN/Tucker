using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanBarı : MonoBehaviour
{
	Vector3 localScale;
	void Start()
	{
		localScale = transform.localScale;
	}


	void Update()
	{
		localScale.x = karakter.can;
		transform.localScale = localScale;

	}
}
