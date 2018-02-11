using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {


	// Use this for initialization
	void Start ()
	{
		//var rb = this.GetComponent<Rigidbody>();
		//if (rb != null)
		//	rb.velocity = new Vector3(1,0,0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		print("Enter");
	}

	void OnTriggerExit(Collider other)
	{
		print("Exit");
	}
}
