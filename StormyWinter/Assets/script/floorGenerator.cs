using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorGenerator : MonoBehaviour {

    private int counter;
    public int interval;
    public GameObject floor1;
    public GameObject floor2;


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
            createPosition.y = createPosition.y - 8;
            createPosition.y = createPosition.y + Random.Range(0, 14);
            GameObject floor = Instantiate(floor1, createPosition, Quaternion.identity);
            if (floor != null)
            {
                floor.GetComponent<floor>().speed = Random.Range(2,6);
            }
        }
    }

}
