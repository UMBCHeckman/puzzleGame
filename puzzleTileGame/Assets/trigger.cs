using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour {
    public GameObject obj1;
    public GameObject obj2;
    public bool obj1Bool = false;
    public bool obj2Bool = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(obj1Bool)
            print(obj1);
	}
    void OnTriggerStay2D(Collider2D col)
    {
        print(col);
        if (!obj1Bool)
        {
            obj1 = GameObject.Find(col.name);
            obj1Bool = true;
        }
    }
}
