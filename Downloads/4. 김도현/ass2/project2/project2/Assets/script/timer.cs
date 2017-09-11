using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour {
	public TextMesh textmash;
	public float time_f = 0f;

	// Use this for initialization
	void Start () {
		textmash.text = "0";
		time_f = 0f;
	}

	// Update is called once per frame
	void Update () {
		time_f += Time.deltaTime;
		int time = (int)time_f % (int)60;
		textmash.text = time.ToString();
		//	GetComponents(TextMesh).text = "0";

		if (time >= 10) {	
			Application.LoadLevel (0);
		}
	}

}
