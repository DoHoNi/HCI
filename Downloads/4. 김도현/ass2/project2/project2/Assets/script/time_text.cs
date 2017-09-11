using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time_text : MonoBehaviour {

	public Text typeTex;

	// Use this for initialization
	void Start () {
		typeTex.text = PlayerPrefs.GetString("time");
	}
	
	// Update is called once per frame
	void Update () {
	}
}
