using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemygen_3 : MonoBehaviour {
	private static enemygen_3 instance;

	public GameObject enemy;

	void Awake() {
		instance = this;
	}

	void Start () {
		InvokeRepeating ("CreateEnemy", 3f, 5f);
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
