using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MvR.Types;
using UnityEngine.SceneManagement;

using UnityEngine.UI;


public class Spawn : MonoBehaviour
    {


        // Array of enemies and their numbers.
        public Enemies[] enemies;

        // How many seconds to wait before creating a new enemy
        public float spawnDelay = 7;
    public float powerSpawnDelay=18;
    public float WaitingTime = 30;
    public float nokoriWeakTeki = 2;
    internal float spawnDelayCount = 0;

        // A list of the spwan points from which enemies appear
        public Transform[] spawnPoints;

        // The total number of enemies in the level
        private static float enemiesTotal=0;
        public float enemiesCreated = 0;
    private float GameTimer = 0;
    internal float enemiesKilled = 0;
 // General use index
        private int index = 0;

    public float RangeMin = 0;
    public float RangeMax = 0;

    public static void ResetEnemy()
    {
        enemiesTotal = 0;
    }

    public void Start()
        {

        for (int enemyIndex = 0; enemyIndex < enemies.Length; enemyIndex++)
            {
                // Add to total enemies
                enemiesTotal += enemies[enemyIndex].enemyCounts;
            
        }
        index = -1;
        print(enemiesTotal);
    }

    public static void SubEnemy()
    {
      //  print(enemiesTotal);
        enemiesTotal--;
       
        if(enemiesTotal==0)
        {
            SEManager.Instance.Play(SEManager.SE.WIN);
            print("WIN");
            Time.timeScale = 0;
            SceneManager.LoadScene("GameClear", LoadSceneMode.Additive);
        }
    }

    public static float CountEnemy(float count)
    {
        count = 10; //enemiesTotal;
        print(count);
        return (count);
    }
   
    void Update()
    {
        print(enemiesTotal);
        if (Mathf.Round(GameTimer) > WaitingTime)
        {
            if (enemies[0].enemyCounts > nokoriWeakTeki)
            {
                index = 0;
                if(Mathf.Round(GameTimer)>=180)
                {
                    spawnDelay = Random.Range(3f, 15f);
                }
            }
            if ((enemies[0].enemyCounts <= nokoriWeakTeki) && (enemies[1].enemyCounts > 0))
            {
                index = Random.Range(0, enemies.Length-1); ;
                spawnDelay = Random.Range(RangeMin, RangeMax);

            }

            if  ((enemies[0].enemyCounts <= 1) && (enemies[1].enemyCounts <=1) && (enemies[2].enemyCounts <= 1))
            {
                index = Random.Range(0, enemies.Length); ;
                spawnDelay = Random.Range(1f, 2f);

            }

        }
        else
        {
            index = 99;
        }



           
        // Count up the spawn delay
        spawnDelayCount += Time.deltaTime;
        GameTimer += Time.deltaTime;
      //  print(Mathf.Round(GameTimer));
        // Choose a random spawn point from the list
        int spawnIndex = Random.Range(0, spawnPoints.Length);
        foreach (Enemies thisAttacker in enemies)
        {
            if (spawnDelayCount >= spawnDelay)
            {
                // Go through each enemy type and create an enemy at a random spawn point
                if (index < enemies.Length)
                {
                    // If we still have enemies of this type, proceed
                    if (enemies[index].enemyCounts > 0)
                    {
                       /* if(Mathf.Round(GameTimer) %60==0)
                        {
                            print(GameTimer);
                            spawnDelayCount = -30;
                        }
                        else*/
                        {
                            spawnDelayCount = 0;
                        }
                      
                        // Count down the enemy amount
                        enemies[index].enemyCounts--;
                        enemiesCreated++;
                        Transform _newEnemy = (Transform)Instantiate(enemies[index].enemyTypes, spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                        _newEnemy.transform.parent = spawnPoints[spawnIndex].transform;
                    }
                   // index++;

                


                }
                
            }
        }
        index++;
        if (index > enemies.Length) { index = 0; }
    }
    }








