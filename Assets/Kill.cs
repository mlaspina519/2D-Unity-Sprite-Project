using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour {
	private AudioSource audio;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// Destroys bullet, plane, and plays sound on collision
	void OnTriggerEnter2D(Collider2D other) {
		if(other.CompareTag("Enemy")) {
			if (other.GetComponent<EnemyController>().Health == 1) {
				audio.Play();
				Destroy(other.gameObject, .5f);
				Destroy(this.gameObject, .5f);
			} else {
				audio.Play();
				Destroy(this.gameObject, .5f);
				other.GetComponent<EnemyController>().Hit();
			}
		}
	}
}