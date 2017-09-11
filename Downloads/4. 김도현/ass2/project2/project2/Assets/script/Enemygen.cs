using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemygen : MonoBehaviour {
	private static Enemygen instance;

	public GameObject enemy;

	void Awake() {
		instance = this;
	}

	void Start () {
		InvokeRepeating ("CreateEnemy", 3f, 6f);
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
