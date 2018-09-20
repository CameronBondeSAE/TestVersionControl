using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
	private int value;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButton(0))
		{
			print("CLICK!");
			if (value < 5)
			{
				print("MORE!");
			}
		}
	}
}
