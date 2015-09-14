using UnityEngine;
using System.Collections;

public class falsefloor : MonoBehaviour {

	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.Alpha1) == true) {
			gameObject.GetComponent<BoxCollider> ().enabled = false;
			gameObject.GetComponent<MeshRenderer> ().enabled = false;

		}
	
	}
}
