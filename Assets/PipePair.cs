﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipePair : MonoBehaviour {

	public float speed = 1.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		gameObject.transform.Translate (Vector3.left * speed * Time.deltaTime);
		
	}
}
