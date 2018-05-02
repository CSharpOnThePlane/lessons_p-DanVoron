using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour {
	public Transform cube;
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		float dist = Vector3.Distance(cube.position, transform.position);
		if (dist < 10) {
			transform.position = new Vector3 (262, 5.5f, 305);
		}
	}
}
