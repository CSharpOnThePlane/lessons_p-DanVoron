using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {
	float sec = 20;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		float kadr = Time.deltaTime;
		if (sec > 0) 
		{
			sec =  sec - kadr;
		}

		print((int)sec);
		if(sec<0)
		{
			print(" время вышло");
		}

	}
}
