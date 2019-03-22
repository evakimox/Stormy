using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateCampFire : MonoBehaviour {

    public GameObject campFirePrefab;
    private bool haveFire;
    private GameObject campFire;


	// Use this for initialization
	void Start () {
        haveFire = false;
    }
	
	// Update is called once per frame
	void Update () {
        if(campFire != null) {
            campFire.transform.position = transform.position;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "main")
        {
            float hp = other.gameObject.GetComponent<playerControl>().hp;
            if (hp > 0 && !haveFire)
            {
                campFire = Instantiate(campFirePrefab, transform.position, Quaternion.identity);
                haveFire = true;
            }
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        //this is the camp fire logic...
        if(other.gameObject.tag == "main" && haveFire) {
            float hp = other.gameObject.GetComponent<playerControl>().hp;
            if (hp > 0 && hp < other.gameObject.GetComponent<playerControl>().fullHp) {
                other.gameObject.GetComponent<playerControl>().hp = hp + 0.5f;
            }
        }
    }
}
