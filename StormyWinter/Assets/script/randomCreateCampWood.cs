using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomCreateCampWood : MonoBehaviour {

    public float probGenerateCampwood;
    private bool haveWood;
    public GameObject campWoodPrefab;
    private GameObject campWood;
	// Use this for initialization
	void Start () {
        haveWood = false;
        float randomNumber = Random.Range(0f, 100f);
        if(randomNumber < probGenerateCampwood) {
            campWood = Instantiate(campWoodPrefab, transform.position, Quaternion.identity);
            haveWood = true;
        }

    }
	
	// Update is called once per frame
	void Update () {
        if (haveWood) {
            Vector3 pos = transform.position;
            pos.y = pos.y + 0.7f;
            campWood.transform.position = pos;
        }
    }
}
