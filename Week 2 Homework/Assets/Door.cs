using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.E) == true) {
			Rigidbody rb = gameObject.GetComponent<Rigidbody> ();
			rb.AddForce (new Vector3 (0, 20, 0));
		}
	}
}
