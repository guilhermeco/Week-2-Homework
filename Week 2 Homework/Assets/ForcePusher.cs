using UnityEngine;
using System.Collections;

public class ForcePusher : MonoBehaviour {

	private float xForce;
	private int zTourqe;
	private GameObject redCube;

	// Use this for initialization
	void Start () {
		xForce = 150;
		zTourqe = -150;
		redCube = GameObject.Find ("redCube");
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.Space) == true) {
			Rigidbody rb = gameObject.GetComponent<Rigidbody> ();
			rb.AddForce (new Vector3 (xForce, 0, 0));
			rb.AddTorque (new Vector3 (150, 0, 0));

		}
			if (Input.GetKey (KeyCode.Z) == true) {
				Rigidbody rb = gameObject.GetComponent<Rigidbody>();
				rb.AddForce (new Vector3 (zTourqe, 0, 0));
				rb.AddTorque (new Vector3 (150, 0, 0));
				redCube.transform.localScale = redCube.transform.localScale + new Vector3 (0.1f, 0.1f, 0.1f);
		}
	}
}
