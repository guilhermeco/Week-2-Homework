using UnityEngine;
using System.Collections;

public class ResetPositions : MonoBehaviour {
	
	void OnTriggerExit() {
		GameObject.Find ("RightRamp").GetComponent<BoxCollider> ().enabled = true;
		GameObject.Find ("RightBall").transform.position = new Vector3 (-15, 15, 0);
	
	}
}
 