using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parent : MonoBehaviour
{
	public GameObject q; //arm;
	public GameObject w; //battery;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void OnCollisionEnter(Collision otherObj)
	{
		if(otherObj.gameObject == GameObject.Find("w"))
		{
			w.transform.parent = GameObject.Find("q").transform;
		}
	}
}
