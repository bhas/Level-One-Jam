using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public GameObject Player;
    private Rigidbody2D rb;
    public int Speed;
    public float RotationSpeed;
    private float Xr;
    private float Yr;
    public float MaxSpeed;

	// Use this for initialization
	void Start () {
        rb = Player.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        var dx = Input.GetAxis("Horizontal");
        var dy = Input.GetAxis("Vertical");
        var dir = new Vector3(dx, dy, 0).normalized;
        var shit = Player.transform.up;
        
        var evenmoreshit = Vector3.RotateTowards(shit, dir, RotationSpeed, 0);
        print(shit + "    " + dir + "    " + evenmoreshit);        
        //Player.transform.Rotate(new Vector3(evenmoreshit.x,evenmoreshit.y,0) * RotationSpeed);
        Player.transform.up = new Vector2(evenmoreshit.x,evenmoreshit.y);
        Player.transform.Translate(Vector2.up * Speed/100);

        if (rb.velocity.magnitude > MaxSpeed) {

            Yr = rb.velocity.y * (MaxSpeed / rb.velocity.magnitude);
            Xr = rb.velocity.x * (MaxSpeed / rb.velocity.magnitude);

            rb.velocity = new Vector2(Xr,Yr);
        }


    }
}
