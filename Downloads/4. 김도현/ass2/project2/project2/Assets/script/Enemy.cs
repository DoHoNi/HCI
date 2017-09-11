using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	private bool right; 
	float moveSpeed = 1.3f;
	void Start () {
		right = Random.Range (0, 2)==1;
		if (right) {
			transform.position = new Vector3 (8f, Random.Range (1, 5), 0);

		} else{
			transform.position = new Vector3 (2f, Random.Range (1, 5), 0);
		}
	}

	void Update () {
		if (right) {
			moveControl (-1);
		} else {
			moveControl (1);
		}
	}

	void OnCollisionEnter2D(Collision2D other) {

		//Application.LoadLevel (0);
		GameObject.Destroy(this.gameObject, 2f);
	}
		
	void moveControl(int left){
		
		float distanceX = moveSpeed * Time.deltaTime;
		this.gameObject.transform.Translate(left *distanceX , 0, 0);
	}
}
	