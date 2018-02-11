using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTwo : MonoBehaviour {

    public GameObject Enemy;
    public float EnemySpeed;
    private Rigidbody2D rb;
    public GameObject Player;
    public float pushPower;
    public float EnemyDistance;


    // Use this for initialization
    void Start () {

        Player = GameObject.Find("Player");
        rb = Enemy.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {

        Vector3 target = Player.transform.position;
        Vector3 dir = -Enemy.transform.position + Player.transform.position;
        if (dir.magnitude > EnemyDistance)
        {
            Enemy.transform.Translate(dir.normalized * EnemySpeed / 100);
        }
        else
        {
            return;
        }
        

    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("PowerUpSpeed2"))
        {
            EnemySpeed = EnemySpeed * 2;
            Destroy(other.gameObject);
        }
    }
}
