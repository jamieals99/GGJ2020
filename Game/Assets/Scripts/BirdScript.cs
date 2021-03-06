﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    private BirdScript birdScript;
    public GameObject bird;
    int Bird;
    public Camera cam;
    public Vector2 spriteSize;
    Vector2 position;
    public float nextSpawn;

    Vector3 cameraPosition;
    public void Start()
    {
        nextSpawn = Time.timeSinceLevelLoad + 7;
        cam = FindObjectOfType<Camera>();
    }

    public void FixedUpdate()
    {
        cameraPosition = cam.transform.position;
        if (Time.timeSinceLevelLoad > nextSpawn)
        {
            if (nextSpawn <= 30)
            {
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);

                nextSpawn += 7;
            }
            else if (nextSpawn > 30 && nextSpawn <= 60)
            {
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);

                nextSpawn += 7;
            }
            else if (nextSpawn > 60 && nextSpawn <= 90)
            {
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);


                nextSpawn += 7;
            }
            else if (nextSpawn > 90 && nextSpawn <= 120)
            {
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);

                nextSpawn += 7;
            }
            else
            {
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);
                position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5f, 5f));
                Instantiate(bird, position, Quaternion.identity);

                nextSpawn += 7;
            }
        }
        
    }
}
