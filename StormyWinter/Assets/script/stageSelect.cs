using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stageSelect : MonoBehaviour {
    public string levelName;
    Vector3 scale;
	// Use this for initialization
	void Start () {
        scale = transform.localScale;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseEnter()
    {
        transform.localScale = 1.2f * scale;

    }

    private void OnMouseExit()
    {
        transform.localScale = scale;
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            SceneManager.LoadScene(levelName);
        }
    }
}
