using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_3_2 : MonoBehaviour {

	private float verti; 
	private float hori;
	public float time;
	void Start () {
		time = 0f;
		verti = Random.Range (2, 10);
		hori = Random.Range (1, 5);

		transform.position = new Vector3 (-1 * verti, hori, 0);

	}

	void Update () {

	}

}
