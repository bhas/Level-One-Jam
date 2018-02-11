using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		this.transform.up = GetComponent<Rigidbody2D>().velocity.normalized;
		Invoke("Destroy", 2);
	}

	private void Destroy()
	{
		Destroy(gameObject);
	}
}
