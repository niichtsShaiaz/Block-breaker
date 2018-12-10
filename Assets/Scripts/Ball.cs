using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public Rigidbody2D rb;
    public float speed;
    public bool gameStarted = false;

	// Use this for initialization
	void Start () {
        rb.isKinematic = true;
        
	}
	
	// Update is called once per frame
	void Update () {
        if( gameStarted == false && Input.GetKeyDown(KeyCode.Space)) {
            transform.SetParent(null);
            rb.isKinematic = false;
        rb.AddForce(new Vector2(speed, speed));
            gameStarted = true;

        }
        if (transform.position.y <= -4)
            Destroy(gameObject);
        
    }
}
