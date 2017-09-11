using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class star : MonoBehaviour {

	private float speed;
	// Use this for initialization
	void Start () {
		speed = 5f;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			if(transform.position.y<-0.5)
			transform.Translate (Vector3.up *speed *Time.deltaTime);
		}
		
	}
	void OnCollisionEnter2D(Collision2D other) {

		if (other.gameObject.tag.Equals("ball"))
		{
			PlayerPrefs.SetInt ("type", 4);
			Application.LoadLevel (0);
		}
	}

}
