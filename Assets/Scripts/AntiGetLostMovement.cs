using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiGetLostMovement : MonoBehaviour {
    void Start() {
    }

    void Update() {
		/** teleport back to start location if the player got lost */
		if (transform.position.y <= -24) {
			transform.position = new Vector3(-1.8f, 10, 1);
		}
    }
}
