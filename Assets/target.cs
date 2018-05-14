using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Player") {
			Destroy (gameObject);
			Destroy (other.gameObject);
			raycontroller.score += 1;
			print( raycontroller.score);
		}
	}
}