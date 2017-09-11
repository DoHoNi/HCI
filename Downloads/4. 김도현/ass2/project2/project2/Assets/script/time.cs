using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour {

	public Text timerText;

	public float timer = 0f;
	public static string time_string;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(this);
		timerText.text = "00:00";
		timer = 0f;
	}

	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		int timeMin = (int)(timer/ 60.0f);
		int timeSec = (int)(timer) % (int)60;
		time_string = timeMin.ToString () + ":" + timeSec.ToString ();
		timerText.text = time_string;
		PlayerPrefs.SetString ("time", time_string);
	}
}
