using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour {

	public GameObject prefab = null;
	public float spawnDelay = 3.0f;
	public float timer = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		timer = timer + Time.deltaTime;
		if (timer >= spawnDelay) {
			Instantiate (prefab, gameObject.transform.position, gameObject.transform.rotation);
			timer = 0.0f;
		}
	}
}
