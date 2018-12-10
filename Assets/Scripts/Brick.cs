using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {
    public Rigidbody2D rb;
    public int Health;
    public Material onehp, twohp, threehp;
    public gameManager gm;

    // Use this for initialization
    void Start () {
        rb.isKinematic = true;
        pickColour();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Health--;

            if (Health <= 0)
            {
                increaseScore(5);
                Destroy(gameObject);
            }

            else {
                increaseScore(1);
            pickColour();
            }
        }
    }
    private void pickColour()
    {
        switch (Health)
        {


        case 1:
                gameObject.GetComponent<Renderer>().material = onehp;
            break;

        case 2:
                gameObject.GetComponent<Renderer>().material = twohp;
                break;
            case 3:
                gameObject.GetComponent<Renderer>().material = threehp;
                break;

            default:
            break;
        }
    }

    private void increaseScore (int amount)
    {
        gm.score += amount;
        gm.scoreboard();
    }
}
