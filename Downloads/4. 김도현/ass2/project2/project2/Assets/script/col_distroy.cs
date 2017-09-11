using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col_distroy : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag.Equals("ball"))
		{
			PlayerPrefs.SetInt ("type", 3);
			Destroy(other.gameObject);
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
