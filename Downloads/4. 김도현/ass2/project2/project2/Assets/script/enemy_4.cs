using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_4 : MonoBehaviour {

	float moveSpeed = 1.3f;
	void Start () {
		
		transform.position = new Vector3 (11f, -Random.Range (1, 5), 0);
	
	}

	void Update () {
		float distanceX = moveSpeed * Time.deltaTime;
		this.gameObject.transform.Translate(-1 *distanceX , 0, 0);
	}



}
