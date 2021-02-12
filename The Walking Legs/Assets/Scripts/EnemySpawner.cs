using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float spawnRate1 = 0.5f;
    public float spawnRate2 = 0.1f;
    public static float  modifiedTime = 1f;
    float nextSpawn = 0f;
    float nextSpawn2 = 0f;
    float randX, randY;
    float randA, randB;
    public GameObject Enemy;
    public GameObject EnemyRunner;
    public Rigidbody2D PlayerRb;
    bool scoreUp = false;


    void Update()
    {
        TimeUp();
        EnemySpawn();
        EnemyRunnerSpawn();


        
        
    }

    void EnemySpawn()
    {
        randX = Random.Range(8, -8);
        randY = Random.Range(4.5f, -6.5f);
        Vector3 whereToSpawn = new Vector3(randX, randY, 0);


        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate1;

            if ((whereToSpawn - PlayerRb.transform.position).magnitude > 2.4)
            {
                Instantiate(Enemy, whereToSpawn, Quaternion.identity);
            }

        }

    }

    void EnemyRunnerSpawn()
    {
        randA = Random.Range(8, -8);
        randB = Random.Range(4.5f, -6.5f);

        Vector3 whereToSpawn2 = new Vector3(randA, randB, 0);

        if (Time.time > nextSpawn2)
        {
            nextSpawn2 = Time.time + spawnRate2;
            if ((whereToSpawn2 - PlayerRb.transform.position).magnitude > 2.3)
            {
                Instantiate(EnemyRunner, whereToSpawn2, Quaternion.identity);
            }

        }

    }

    public void TimeUp()
    {

        if (ScoreScript.scoreValue == 100)
        {
            scoreUp = true;
            if (scoreUp == true)
            {
                Time.timeScale = modifiedTime;
                modifiedTime =1.2f;
                scoreUp = false;

            }    
        }

        if (ScoreScript.scoreValue == 250)
        {
            scoreUp = true;
            if (scoreUp == true)
            {
                Time.timeScale = modifiedTime;
                modifiedTime = 1.3f;
                scoreUp = false;

            }
        }

        if (ScoreScript.scoreValue == 500)
        {
            scoreUp = true;
            if (scoreUp == true)
            {
                Time.timeScale = modifiedTime;
                modifiedTime = 1.4f;
                scoreUp = false;

            }
        }

        if (ScoreScript.scoreValue == 1000)
        {
            scoreUp = true;
            if (scoreUp == true)
            {
                Time.timeScale = modifiedTime;
                modifiedTime = 1.6f;
                scoreUp = false;

            }
        }

        if (ScoreScript.scoreValue == 1500)
        {
            scoreUp = true;
            if (scoreUp == true)
            {
                Time.timeScale = modifiedTime;
                modifiedTime = 1.8f;
                scoreUp = false;

            }
        }

        if (ScoreScript.scoreValue == 2000)
        {
            scoreUp = true;
            if (scoreUp == true)
            {
                Time.timeScale = modifiedTime;
                modifiedTime = 2f;
                scoreUp = false;

            }
        }

        if (ScoreScript.scoreValue == 2500)
        {
            scoreUp = true;
            if (scoreUp == true)
            {
                Time.timeScale = modifiedTime;
                modifiedTime = 2.2f;
                scoreUp = false;

            }
        }

        if (ScoreScript.scoreValue == 3000)
        {
            scoreUp = true;
            if (scoreUp == true)
            {
                Time.timeScale = modifiedTime;
                modifiedTime = 2.4f;
                scoreUp = false;

            }
        }

        if (ScoreScript.scoreValue == 3500)
        {
            scoreUp = true;
            if (scoreUp == true)
            {
                Time.timeScale = modifiedTime;
                modifiedTime = 2.6f;
                scoreUp = false;

            }
        }


    }



    
}
