using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerForPro : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	float sec = 0;
	// Update is called once per frame
	void Update () 
	{
		
		float kadr = Time.deltaTime;
		sec =  sec + kadr;
		print ("прошло" + " " + (int)sec + " секунд");
		//привет не воруй код		
	}
}
