using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject PowerUpSpeed;
    public GameObject PowerUpSpikes;
    public GameObject EnemyTwo;

    // Use this for initialization
    void Start()
    {

        SpawnEnemies(5);
        SpawnEnemiesTwo(2);
        SpawnPUS(5);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnEnemies(int nEnemies)
    {
        for (var i = 0; i < nEnemies; i++)
        {
            Vector3 ePosition = new Vector3(Random.Range(-8, 8), Random.Range(-8, 8), 0);
            var hitdetect = Physics.OverlapSphere(ePosition, 3);

            if (hitdetect.Length == 0)
            {
                Instantiate(Enemy, ePosition, Quaternion.identity);
            }
            else
            {
                i = i - 1;

            }





        }


    }

    void SpawnPUS(int nPU)
    {
        for (var i = 0; i < nPU; i++)
        {
            Vector3 ePosition = new Vector3(Random.Range(-8, 8), Random.Range(-8, 8), 0);
            var hitdetect = Physics.OverlapSphere(ePosition, 3);

            if (hitdetect.Length == 0)
            {
                Instantiate(PowerUpSpeed, ePosition, Quaternion.identity);
            }
            else
            {
                i = i - 1;

            }

        }

    }

    void SpawnPUspikes(int nPU)
    {
        for (var i = 0; i < nPU; i++)
        {
            Vector3 ePosition = new Vector3(Random.Range(-8, 8), Random.Range(-8, 8), 0);
            var hitdetect = Physics.OverlapSphere(ePosition, 3);

            if (hitdetect.Length == 0)
            {
                Instantiate(PowerUpSpikes, ePosition, Quaternion.identity);
            }
            else
            {
                i = i - 1;

            }

        }
    }

    void SpawnEnemiesTwo(int nEnemies)
    {
        for (var i = 0; i < nEnemies; i++)
        {
            Vector3 ePosition = new Vector3(Random.Range(-8, 8), Random.Range(-8, 8), 0);
            var hitdetect = Physics.OverlapSphere(ePosition, 3);

            if (hitdetect.Length == 0)
            {
                Instantiate(EnemyTwo, ePosition, Quaternion.identity);
            }
            else
            {
                i = i - 1;

            }





        }


    }
}
