using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour {

    public int score = 0;
    public bool gameover = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
		
	}

    public void scoreboard()
    {
        //this stupid tmp
        //gameObject.GetComponent<TMPro>().text = "Score: " + score; 
    }
}
