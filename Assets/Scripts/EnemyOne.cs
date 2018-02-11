using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyOne : MonoBehaviour {

    public GameObject Enemy;
    public float EnemySpeed;
    private Rigidbody2D rb;
    public GameObject Player;
    public float pushPower;

	// Use this for initialization
	void Start () {

        Player = GameObject.Find("Player");

        rb = Enemy.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 target = Player.transform.position;
        Vector3 dir = - Enemy.transform.position + Player.transform.position;

        Enemy.transform.Translate(dir.normalized*EnemySpeed/100);
		
	}


    //PowerUp1 and Kill
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("PowerUpSpeed2"))
        {
            EnemySpeed = EnemySpeed * 2;
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Player"))
        {
            Vector3 dir = -Enemy.transform.position + Player.transform.position;
            rb=other.gameObject.GetComponent<Rigidbody2D>();
            rb.velocity = dir.normalized * pushPower;
            Destroy(Enemy.gameObject);
        }

    }


}
