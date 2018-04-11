using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodTest : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		float x = transform.position.x;
		float y = transform.position.y;
		float z = transform.position.z;
		print ("x =" + x + "y =  " + y + "z = " + z );
	}
}
