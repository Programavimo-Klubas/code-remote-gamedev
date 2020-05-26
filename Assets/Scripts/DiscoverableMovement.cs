using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscoverableMovement : MonoBehaviour {
    void Start() {
    }

	void OnCollisionEnter2D(Collision2D other) {
		if (other.collider.name == "doodle") {
			Debug.Log("DOODLE!");
			/** make visible! the important part is the last one - alpha */
			gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
		}
	}

    void Update() {
    }
}
