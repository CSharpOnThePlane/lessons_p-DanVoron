using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour 
{
	void OnTriggerEnter(Collider other)
	{
		transform.position = new Vector3 (40,59,170);
	}
}
