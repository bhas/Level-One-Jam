using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject Player;
    public GameObject Camera;
    private Vector3 offset;
    private Vector3 ppos;
    public float height;

	// Use this for initialization
	void Start () {
        offset = new Vector3(0,0,-height);
	}
	
	// Update is called once per frame
	void Update () {
        ppos = Player.transform.position;
        Camera.transform.position = ppos + offset;
	}
}
