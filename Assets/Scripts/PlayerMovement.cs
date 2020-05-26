using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    void Start() {
       	gameObject.name = "doodle"; 
    }

    void OnCollisionEnter2D(Collision2D other) {
        if (gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0) {
            gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 420f);
        }

    }

    void Update() {
        if (Input.GetKey(KeyCode.A)) {
            transform.Translate(Vector3.left * 0.5f);
        }

        if (Input.GetKey(KeyCode.D)) {
            transform.Translate(Vector3.right * 0.5f);
        }
    }
}
