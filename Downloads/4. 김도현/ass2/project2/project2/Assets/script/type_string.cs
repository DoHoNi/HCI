using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class type_string : MonoBehaviour {

	public Text typeTex;

	// Use this for initialization
	void Start () {
		typeTex.text = PlayerPrefs.GetInt("type").ToString();
	}

	// Update is called once per frame
	void Update () {
	}

}
