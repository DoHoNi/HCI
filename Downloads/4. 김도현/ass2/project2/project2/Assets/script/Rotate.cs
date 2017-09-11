using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {


	float time_f;

	// Use this for initialization
	void Start () {
		
		time_f = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		time_f += Time.deltaTime/10;
		transform.Rotate (0, 0, time_f/5000);

		if (Input.GetKey (KeyCode.RightArrow)) {
			time_f = 0f;
			transform.Rotate(0,0,-3);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			time_f = 0f;
			transform.Rotate(0,0,3);
		}
	}
}
