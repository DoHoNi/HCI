using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_3_1 : MonoBehaviour {
	private float speed;

	// Use this for initialization
	void Start () {
		
		speed = 3f;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			if(transform.position.y<4.5)
				transform.Translate (Vector3.up *speed *Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.A)) {
			if(transform.position.x>-8.0)
			transform.Translate (Vector3.left *speed *Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.S)) {
			if(transform.position.y>0.5)
			transform.Translate (Vector3.down *speed *Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.D)) {
			if(transform.position.x<-0.5)
			transform.Translate (Vector3.right *speed *Time.deltaTime);
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag.Equals("ball"))
		{
			Destroy(other.gameObject);
		}
	}
}
	
