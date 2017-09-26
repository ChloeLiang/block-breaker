using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollider : MonoBehaviour {
	void OnCollisionEnter2D (Collision2D collision) {
		this.GetComponent<AudioSource>().Play();
	}
}
