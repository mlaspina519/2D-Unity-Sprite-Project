using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
	private Rigidbody2D rigid;
	public Vector2 movement = new Vector2(300, 100);

	// Initialization
	void Start() {
		rigid = GetComponent<Rigidbody2D>();
	}

	// Physics - fixed rate
	void FixedUpdate() {
		rigid.velocity = movement * Time.fixedDeltaTime;
	}

	// On collision with wall
	void OnTriggerEnter2D(Collider2D other) {

        // When bouncing off a wall, randomly changes speed
		if (other.CompareTag ("Vertical Wall")) {
			movement = new Vector2 (-movement.x, movement.y + Random.Range(-75f, 75f));
			transform.localScale = new Vector2 (-transform.localScale.x, transform.localScale.y);
		} else if (other.CompareTag ("Horizontal Wall")) {
			movement = new Vector2 (movement.x, -movement.y + Random.Range(-75f, 75f));
		}
	}
}