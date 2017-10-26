using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour {

	public float force = 100.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			gameObject.GetComponent<Rigidbody> ().velocity = Vector3.zero;
			gameObject.GetComponent<Rigidbody> ().AddForce (Vector3.up * force);
		}
	}

	void OnCollisionEnter (Collision other) {
		if (other.gameObject.tag == "Ground" || other.gameObject.tag == "Pipe") {
			Application.LoadLevel ("FlappyBird");
		}
	}
}
