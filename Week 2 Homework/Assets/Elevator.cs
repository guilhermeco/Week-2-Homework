using UnityEngine;
using System.Collections;

public class Elevator : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey (KeyCode.Space) == true) {
			Rigidbody rb = gameObject.GetComponent<Rigidbody> ();
			rb.AddForce (new Vector3 (0, 40, 0));

//			GameObject.Find ("Floor").SetActive (false);

			}


			if (Input.GetKey (KeyCode.Z) == true) {
				Rigidbody rb = gameObject.GetComponent<Rigidbody> ();
				rb.AddTorque (new Vector3 (0, 0, 5));
			}

		if (Input.GetKey (KeyCode.X) == true) {
			Rigidbody rb = gameObject.GetComponent<Rigidbody> ();
			rb.AddTorque (new Vector3 (0, 0, -6));
		}
	}
}	