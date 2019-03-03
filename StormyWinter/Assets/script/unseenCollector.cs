using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unseenCollector : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag != "garbageCollector")
        {
            if(other.gameObject.tag == "main") {
                other.gameObject.GetComponent<playerControl>().hp = -1;
                return;
            }
            Destroy(other.gameObject);
        }
    }
}
