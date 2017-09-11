using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ob_3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D other) {

		GameObject.Destroy(this.gameObject, 2f);
	}
}
