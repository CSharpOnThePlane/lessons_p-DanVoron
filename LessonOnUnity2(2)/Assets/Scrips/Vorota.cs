using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vorota : MonoBehaviour {
	public GameObject Machik;
	// Use this for initialization
	void Start () {
		
	}
	void OnTriggerEnter(Collider other)
	{
		// если столкнулись с объектом с тегом Снаряд
		if (other.tag == "ball") {
			// то самоуничтожаемся через секунду
			Destroy (other.gameObject);
			Instantiate(Machik);	
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
