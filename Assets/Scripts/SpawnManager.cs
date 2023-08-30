using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstacles;
    public GameObject[] golds;
    private float minGoldRangeY = -3f;
    private float maxGoldRangeY = 0.5f;
    private float minXRange = 4f;  //obstacle lar y de hareket etmicek x te oluþacak 
    private float maxXRange = 11f;
    public float maxTime;
    float timer;
    
    

    // Start is called before the first frame update
    void Start()
    {

        //InvokeRepeating("SpawnRandomObstacles", 2f, 5f);
        //InvokeRepeating("SpawnRandomGold", 1.5f, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.gameOver == false)
        {
            timer += Time.deltaTime;
            if (timer >= maxTime)
            {
                SpawnRandomObstacles();
                SpawnRandomGold();
                timer = 0;
            }
        }
        //bu kod bloðu 3.5 sn de bir obstacle üretmesini saðlýyor.
     
        //

    }
    void SpawnRandomObstacles()
    {
        int obstacleIndex = Random.Range(0, obstacles.Length);
        GameObject newObstacles = Instantiate(obstacles[obstacleIndex]);
        newObstacles.transform.position = new Vector2(Random.Range(minXRange, maxXRange), -4.3f);
        //Vector2 spawnPos = new Vector2(Random.Range(minXRange, maxXRange), transform.position.y);  
    }
    void SpawnRandomGold()
    {
        int goldIndex = Random.Range(0, golds.Length);
        GameObject newGolds = Instantiate(golds[goldIndex]);
        newGolds.transform.position = new Vector2(Random.Range(minXRange, maxXRange), Random.Range(minGoldRangeY, maxGoldRangeY));
    }
}
