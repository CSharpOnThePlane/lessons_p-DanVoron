﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cords : MonoBehaviour {
	public Transform cube;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () 
	{
		float dist = Vector3.Distance (cube.position, transform.position);
		print ((int)dist);
		if (dist < 10) 
		{
			print ("АСТАРОЖНА РЯДОМ ПИТУХ");
		}
		
	}
}
