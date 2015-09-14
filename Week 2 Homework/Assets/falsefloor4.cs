using UnityEngine;
using System.Collections;

public class falsefloor4 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

		if (Input.GetKey (KeyCode.Alpha4) == true) {
			gameObject.GetComponent<BoxCollider> ().enabled = false;
			gameObject.GetComponent<MeshRenderer> ().enabled = false;
	}
}
}