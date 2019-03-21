using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorGenerator : MonoBehaviour {

    private int counter;
    public int interval;
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
            GameObject type = floorIce;
            if(Random.Range(0f,10f) > 7f) {
                type = floorWood;
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
