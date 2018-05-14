using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class enemycontroller : MonoBehaviour {
	public GameObject target;
	public GameObject stage;
	float stageX;
	float stageY;
	float stageZ;
	float time;

	// Use this for initialization
	void Start () {
		
		// オブジェクトの大きさを取得している
		stageX = stage.GetComponent<Renderer> ().bounds.size.x;
		stageY = stage.GetComponent<Renderer> ().bounds.size.y;
		stageZ = stage.GetComponent<Renderer> ().bounds.size.z;

		generateEnemy ();
		time = 0;
	}
	// Update is called once per frame
	void Update () {
		//GameObject[] enemies = GameObject.FindGameObjectsWithTag ("Enemy");
		time += Time.deltaTime;
		if (time >= 5) {
			time = 0;
			generateEnemy ();
		}
	}
	void generateEnemy(){
		for (int i = 0; i < 10; i++) {
			Instantiate (target, stage.transform.position + new Vector3 (Random.Range (-stageX / 2, stageX / 2),
				Random.Range (-stageY / 2, stageY / 2),
				Random.Range (-stageZ / 2, stageZ / 2)), Quaternion.identity);
		}
	}
}