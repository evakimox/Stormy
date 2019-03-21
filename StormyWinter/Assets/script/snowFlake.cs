using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowFlake : MonoBehaviour {
    public float atk;
    public GameObject steam;

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
            GameObject steamGenerated = Instantiate(steam, transform.position, Quaternion.identity);
            steamGenerated.transform.localScale = new Vector2(2f,2f);
            Destroy(gameObject);
        }
    }
}
