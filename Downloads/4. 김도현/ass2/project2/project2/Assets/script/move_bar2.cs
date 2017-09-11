using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_bar2 : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag.Equals("ball"))
		{
			PlayerPrefs.SetInt ("type", 2);
			Application.LoadLevel (0);
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow)) {
			if(transform.position.y<4.5)
			transform.position += new Vector3 (0f, 0.35f, 0f);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			if(transform.position.y>0.5)
			transform.position += new Vector3 (0f, -0.35f, 0f);
		}
	}
}
