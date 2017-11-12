using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	private float horizontalMovement;
	private float verticalMovement;
	private float speed = 7.0f;
    private bool facingRight = false;
    public int health = 3;
    private  Rigidbody2D rigid;
    public GameObject bulletBill;

    public int Health { get { return health; } }

    // Initialization
    void Start() {
            rigid = GetComponent<Rigidbody2D>();
	}
	
	// User input - Once per frame
	void Update() {
        horizontalMovement = Input.GetAxis("Horizontal");
        verticalMovement = Input.GetAxis("Vertical");

        // Fires a bullet
        if(Input.GetButtonDown("Fire1")) {
            OnFireInput();
        }
	}

	// Physics/Movement - fixed rate
    void FixedUpdate() {
        rigid.velocity = new Vector2(verticalMovement * speed, rigid.velocity.y);
        rigid.velocity = new Vector2(horizontalMovement * speed, rigid.velocity.x);

		// Flips plane when changing directions
		if(horizontalMovement < 0 && facingRight || horizontalMovement > 0 && !facingRight) {
			transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
            facingRight = !facingRight;
		}
    }

    // Shoots bullet 
    void OnFireInput() {
        // Shoots in correct direction
		if(facingRight) {
			GameObject bullet = (GameObject)Instantiate (bulletBill, transform.position, Quaternion.identity);
			bullet.transform.localScale = new Vector2(-bullet.transform.localScale.x, bullet.transform.localScale.y);
			bullet.GetComponent<PlayerBullet>().ChangeDirection();
		} else {
			Instantiate(bulletBill, transform.position, Quaternion.identity);
        }
    }

    // Reduces health
    public void Hit() {
        health--;
    }
}