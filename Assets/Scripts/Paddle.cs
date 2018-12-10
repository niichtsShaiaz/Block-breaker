using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
    public float speed;
    public Rigidbody2D rb;
    public float maxX;


    // Use this for initialization
    void Start () {

        
	}
	
	// Update is called once per frame
	void Update () {
        //Grab arrow keys, left arrow, x = -1, right arrow x = 1
        float x = Input.GetAxis("Horizontal");

        if (x < 0)
        {
            MoveLeft();
        }
        if (x == 0)
        {
            Stop();
        }
        if (x > 0 )
        {
            MoveRight();
        }

        //Grab position of paddle and restrict it to within screen boundaries

        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, -maxX, maxX);
        transform.position = position;

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = speed * 2;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = speed / 2;
        }

    }
    //Function to move the padde Left, right, and stop
    void MoveLeft() {
        rb.velocity = new Vector2(-speed, 0);
    }
    void MoveRight()
    {
        rb.velocity = new Vector2(speed, 0);
    }

    void Stop()
    {
        rb.velocity = Vector2.zero;
    }
}
