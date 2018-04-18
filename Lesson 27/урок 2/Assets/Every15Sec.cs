using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  Every15Sec: MonoBehaviour {
	float sec = 0;
	float volna = 0;
	float sec2 = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		float kadr = Time.deltaTime;
		sec2 = sec2 + kadr;
		sec =  sec + kadr;
		if((int)sec%5==0)
		{
			print("Монстры идут");
		}
		if(sec2>5)
		{
			volna++;
			print (volna + "идет");
			sec2 = 0;
		}
	}
}
