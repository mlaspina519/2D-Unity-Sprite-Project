using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBullet : MonoBehaviour {
    private Rigidbody2D rigid;
    private new AudioSource audio;
    public Vector2 movement = new Vector2(200, 0);
    private bool facingLeft = true;

	// Use this for initialization
	void Start() {
		rigid = GetComponent<Rigidbody2D>();
        audio = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void FixedUpdate() {
        if(facingLeft) {
            rigid.velocity = -movement * Time.fixedDeltaTime;
        } else {
            rigid.velocity = movement * Time.fixedDeltaTime;
        }
    }

    // Collision with wall, player, enemy
    void OnTriggerEnter2D(Collider2D other) {
        // Destroys bullet on wall impact
        if(other.CompareTag("Vertical Wall")) {
            Destroy(this.gameObject);
        }

        // Damages enemy if bullet came from player
        if(other.CompareTag("Enemy")) {
            if (other.GetComponent<EnemyController>().Health == 1) {
                audio.Play();
                Destroy(other.gameObject, .5f);
                Destroy(this.gameObject, .5f);
                SceneManager.LoadScene("Medium");
            } else {
                audio.Play();
                Destroy(this.gameObject, .5f);
                other.GetComponent<EnemyController>().Hit();
            }
        }
    }

    // Changes which way bullet faces
    public void ChangeDirection() {
        facingLeft = !facingLeft;
    }
}