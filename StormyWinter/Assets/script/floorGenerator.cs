using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorGenerator : MonoBehaviour {

    private int counter;
    public int interval;
    public GameObject floorNorm;
    public GameObject floorIce;
    public GameObject floorWood;


    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update () {
    }

    private void FixedUpdate()
    {
        counter = counter - 1;
        if(counter <= 0) {
            counter = interval;
            Vector2 createPosition = transform.position;
            GameObject type = floorNorm;
            float randomNumber = Random.Range(0f, 10f);
            if ( randomNumber > 8f) {
                type = floorWood;
            }
            else if (randomNumber < 3f) {
                type = floorIce;
            }
            createPosition.y = createPosition.y - 6;
            createPosition.y = createPosition.y + Random.Range(0, 10);
            GameObject floor = Instantiate(type, createPosition, Quaternion.identity);
            if (floor != null)
            {
                floor.GetComponent<floor>().speed = Random.Range(4,8);
            }
        }
    }

}
