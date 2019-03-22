using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMplayer : MonoBehaviour {
    public static BGMplayer instance = null;
    public static BGMplayer Instance { 
        get { return instance; }
    }

    // Use this for initialization
    void Awake () {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        Debug.Log("before");
        DontDestroyOnLoad(this.gameObject);
        Debug.Log("after");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
