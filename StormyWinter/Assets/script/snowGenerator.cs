using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowGenerator : MonoBehaviour {

    private int counter;
    public int interval;
    public GameObject flurry;
    public float snowATK;


    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
        counter = counter - 1;
        if (counter <= 0)
        {
            counter = interval;
            Vector2 createPosition = transform.position;
            createPosition.x = createPosition.x - 10;
            createPosition.x = createPosition.x + Random.Range(0, 20);
            GameObject snow = Instantiate(flurry, createPosition, Quaternion.identity);
            if (snow != null)
            {
                snow.GetComponent<snowFlake>().atk = snowATK;
                snow.transform.localScale = Random.Range(0, 5) * snow.transform.localScale;
            }
        }
    }
}
