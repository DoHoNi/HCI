using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enermygen4 : MonoBehaviour {

	private static enermygen4 instance;

	public GameObject enemy;

	void Awake() {
		instance = this;
	}

	void Start () {
		InvokeRepeating ("CreateEnemy", 2f, 5f);
	}

	void Update () {

	}

	void CreateEnemy() {
		Instantiate(enemy);
	}

	public static void Cancel() {
		instance.CancelInvoke ();
	}

}
