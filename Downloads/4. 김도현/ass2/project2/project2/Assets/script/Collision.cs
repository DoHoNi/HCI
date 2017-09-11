using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag.Equals("ball"))
		{
			PlayerPrefs.SetInt ("type", 1);
			Application.LoadLevel (0);
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
