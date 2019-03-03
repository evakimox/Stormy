using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowFlake : MonoBehaviour {
    public float atk;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "main")
        {
            float hp = other.gameObject.GetComponent<playerControl>().hp;
            Debug.Log("HP: " + hp);
            hp = hp - atk;
            other.gameObject.GetComponent<playerControl>().hp = hp;
            Destroy(gameObject);
        }
    }
}
