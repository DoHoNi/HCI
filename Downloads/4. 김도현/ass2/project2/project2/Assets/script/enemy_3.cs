using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_3 : MonoBehaviour {

	private float verti; 
	private float hori;
	public float time;
	void Start () {
		time = 0f;
		verti = Random.Range (2, 8);
		hori = Random.Range (1, 4);

		transform.position = new Vector3 (-1 * verti, -1* hori, 0);

	}

	void Update () {
		
	}



}
