using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Floor2Script : MonoBehaviour
{
	public float speed = 0; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0,-speed,0);
		if (this.transform.position.y <= 0)
		{
			this.transform.Translate(0,16,0);
		}
	}
}
