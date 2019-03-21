using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class steamControl : MonoBehaviour {
    float alpha = 1f;
    public AudioSource panSound;

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = new Vector3(0f, 1f, 0f);
        GetComponent<AudioSource>().time = 0.5f;
        GetComponent<AudioSource>().Play();
	}
	
	// Update is called once per frame
	void Update () {
        alpha = alpha - 0.01f;
        if(alpha < 0.01) {
            Destroy(this.gameObject);
        }
        Vector4 steamColor = GetComponent<SpriteRenderer>().color;
        steamColor.w = alpha;
        GetComponent<SpriteRenderer>().color = steamColor;
    }
}
