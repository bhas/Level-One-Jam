using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject Player;
    private Rigidbody2D rb;
    public float Speed;
    public float RotationSpeed;
    private float Xr;
    private float Yr;
    public float MaxSpeed;
    public specialAttack SpecialAttack;
    public float DashPower;
    public bool Controls;
    public float ControlsTime;
    public float DashCoolDown;
    public GameObject target;

    // Use this for initialization
    void Start()
    {
        rb = Player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var dx = Input.GetAxisRaw("Horizontal");
        var dy = Input.GetAxisRaw("Vertical");
        var dir = new Vector3(dx, dy, 0);
        var shit = Player.transform.up;

        //var evenmoreshit = Vector3.RotateTowards(shit, dir, RotationSpeed, 100);

        //Movement
        if (dir.magnitude > 0)
        {   
            if (ControlsTime <= Time.time)
            {
                target.gameObject.transform.position = transform.position + dir.normalized;
                dir = dir.normalized;
                Player.transform.up = dir;
                //Player.transform.up = new Vector2(evenmoreshit.x, evenmoreshit.y);
                Player.transform.Translate(Vector2.up * Speed / 100);
            }
        }

        //MaxSpeed
        if (rb.velocity.magnitude > MaxSpeed)
        {

            Yr = rb.velocity.y * (MaxSpeed / rb.velocity.magnitude);
            Xr = rb.velocity.x * (MaxSpeed / rb.velocity.magnitude);

            rb.velocity = new Vector2(Xr, Yr);
        }
        //Dash
        if (Input.GetKey(KeyCode.Space) && DashCoolDown <= Time.time)
        {
            print(rb.velocity);
            rb.velocity = rb.velocity + (new Vector2(Player.transform.up.x,Player.transform.up.y) * DashPower);
            print(rb.velocity);
            ControlsTime = 1 + Time.time;
            DashCoolDown = 3 + Time.time;

        }

        //SpecialAttack
        if (Input.GetKeyDown(KeyCode.A))
        {
            PerformSpecialAttack();

        }

        

    }

    //PowerUp1
    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("PowerUpSpeed2"))
        {
            Speed = Speed * 2;
            Destroy(other.gameObject);
        }

    }  



    public void PerformSpecialAttack()
    {
        switch (SpecialAttack)
        {
            case specialAttack.Laser:
                print("FIRE MY LAZOR");
                break;
            case specialAttack.Spikes:

                break;
            case specialAttack.Tongue:

                break;
        }
    }

    public enum specialAttack
    { Tongue, Laser, Spikes }

}
