using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class raycontroller : MonoBehaviour {
	public static int score = 0;
	public GameObject bullet;
	public float speed = 60f;
	GameObject bullet1 ;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			bullet1 = (GameObject)Instantiate (bullet, gameObject.transform.position, Quaternion.identity);
			Vector3 direction = ray.direction;
			bullet1.gameObject.GetComponent<Rigidbody> ().velocity = direction * speed;
		}
		if (bullet1.transform.position.z > 500) {
			Destroy (bullet1.gameObject);
		}
		if (score >= 40) {
			SceneManager.LoadScene ("gameclear");
		}
	}
}
