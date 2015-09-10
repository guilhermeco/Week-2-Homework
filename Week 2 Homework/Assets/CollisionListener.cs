using UnityEngine;
using System.Collections;

public class CollisionListener : MonoBehaviour {

	void OnTriggerEnter( Collider otherObject) {

	}

	void OnCollisionEnter( Collision thisCollision) {
		if (thisCollision.gameObject.name == "Player") {
		print ("Physics Collision");
		}
	}
}