using UnityEngine;
using System.Collections;

public class BallPusher : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey (KeyCode.Q) == true) {
			Rigidbody rb = gameObject.GetComponent<Rigidbody> ();
			rb.AddForce (new Vector3 (20, 0, 0));
			}

		if (Input.GetKey (KeyCode.W) == true) {
			Rigidbody rb = gameObject.GetComponent<Rigidbody> ();
			rb.AddForce (new Vector3 (-20, 0, 0));
		}
	}
}