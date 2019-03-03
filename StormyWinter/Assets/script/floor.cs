using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor : MonoBehaviour {

    public float speed;
    private bool speedSet;

	// Use this for initialization
	void Start () {
        speedSet = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate() 
    {
        if (!speedSet) {
            Vector2 velocity = GetComponent<Rigidbody2D>().velocity;
            velocity.x = Mathf.Abs(speed);
            GetComponent<Rigidbody2D>().velocity = -velocity;
        }

    }
}
