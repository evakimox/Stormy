using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerControl : MonoBehaviour {
    public Text scoreBoard;
    private float initTime;
    private float speed = 4f;
    public GameObject healthBar;
    public GameObject healthBarBase;
    private Vector3 healthBarOffset;
    public float hp;
    public float fullHp;
    public float hpBarInitialLength;
    // Use this for initialization
    void Start () {
        initTime = Time.time;
        hp = 100;
        fullHp = 100;
        GetComponent<Rigidbody2D>().freezeRotation = true;
        hpBarInitialLength = healthBar.transform.localScale.x;
        healthBarOffset = healthBarBase.transform.position - transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        movementControl();
        renderHealthBar();
        if(hp <= 0) {
            die();
        }
    }

    void movementControl() {
        if (Input.GetKey("left"))
        {
            GetComponent<Animator>().SetBool("keyPressed",true);
            Vector2 cur = GetComponent<Rigidbody2D>().velocity;
            cur.x = -speed;
            GetComponent<Rigidbody2D>().velocity = cur;
        }
        if (Input.GetKey("right"))
        {
            GetComponent<Animator>().SetBool("keyPressed", true);
            Vector2 cur = GetComponent<Rigidbody2D>().velocity;
            cur.x = speed;
            GetComponent<Rigidbody2D>().velocity = cur;

        }
        if (Input.GetKeyUp("left"))
        {
            GetComponent<Animator>().SetBool("keyPressed", false);
        }
        if (Input.GetKeyUp("right"))
        {
            GetComponent<Animator>().SetBool("keyPressed", false);
        }

        if (Input.GetKeyDown("up"))
        {
            Vector2 cur = GetComponent<Rigidbody2D>().velocity;
            cur.y = 11f;
            GetComponent<Rigidbody2D>().velocity = cur;
        }

        if (GetComponent<Rigidbody2D>().velocity.x > 0)
        {
            Vector2 orientaion = transform.localScale;
            if (orientaion.x > 0)
            {
                orientaion.x = -orientaion.x;
                transform.localScale = orientaion;
            }
        }
        if (GetComponent<Rigidbody2D>().velocity.x < 0)
        {
            Vector2 orientaion = transform.localScale;
            if (orientaion.x < 0)
            {
                orientaion.x = -orientaion.x;
                transform.localScale = orientaion;
            }
        }
    }

    void renderHealthBar() 
    {
        if (hp >= 0)
        {
            Vector2 length = healthBar.transform.localScale;
            length.x = hpBarInitialLength * (hp / fullHp);
            healthBar.transform.localScale = length;
        }
        else {
            Vector2 length = healthBar.transform.localScale;
            length.x = 0;
            healthBar.transform.localScale = length;
        }
        healthBarBase.transform.position = transform.position + healthBarOffset;
    }

    void die() {
        scoreBoard.text = "Survived " + Mathf.Round(Time.time - initTime) + " second.";
        Destroy(healthBar);
        Destroy(healthBarBase);
        Destroy(this.gameObject);
    }

    void FixedUpdate()
    {

    }


}
