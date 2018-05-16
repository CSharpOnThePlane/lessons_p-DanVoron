using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Svetofor : MonoBehaviour {
	
	float sec = 0;
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Renderer color = GetComponent<Renderer>();
		sec = sec+ Time.deltaTime;

		if (sec > 10) {
			color.material.color = Color.blue;
		
		}
		if (sec < 10) {
			color.material.color = Color.black;

		}
		if (sec > 20) {
			sec = sec - 20;
		}
	}
}
