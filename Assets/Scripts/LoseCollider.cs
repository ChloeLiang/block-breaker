using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {

	private LevelManager levelManager;

	void OnTriggerEnter2D (Collider2D collider) {
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		levelManager.LoadLevel("Win");
	}

	void OnCollisionEnter2D (Collision2D collision) {
		print ("Collision");
	}
}
