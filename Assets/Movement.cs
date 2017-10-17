using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    private Rigidbody2D rigid;
    public Vector2 movement = new Vector2(200, 0);
    private bool facingLeft = true;

	// Use this for initialization
	void Start () {
		rigid = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (facingLeft) {
            rigid.velocity = -movement * Time.fixedDeltaTime;
        } else {
            rigid.velocity = movement * Time.fixedDeltaTime;
        }
    }

    public void ChangeDirection() {
        facingLeft = !facingLeft;
    }
}