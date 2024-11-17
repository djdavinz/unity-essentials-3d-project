using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour
{
    public GameObject ball;
    public Transform spawnPoint;

    public float maxX;
    public float maxZ;

    // Start is called before the first frame update
    void Start()
    {
        //SpawnBall();

        //Repeat spawn on start without any manual intervention
        InvokeRepeating("SpawnBall",1f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnBall();
        }

        //Convert mouse position from Screenposition to World Position
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 10f;
            Vector3 spawnPos = Camera.main.ScreenToWorldPoint(mousePos);

            Instantiate(ball, spawnPos, Quaternion.identity);


        }
            
    }

    void SpawnBall()
    {
        //Randomly spawn ball at a given range within scene
        float randomX = Random.Range(-maxX, maxX);
        float randomZ = Random.Range(-maxZ, maxZ);

        Vector3 randomSpawnPos = new Vector3(randomX, 10f, randomZ);
        Instantiate(ball, randomSpawnPos, Quaternion.identity);


        //Initialize Ball and SpawnPoint position
        //Instantiate(ball, spawnPoint.position, Quaternion.identity);
    }
}
