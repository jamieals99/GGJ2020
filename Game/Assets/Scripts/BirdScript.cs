using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    private BirdScript birdScript;
    public GameObject bird;
    public GameObject Camera;
    int Bird;
    public Vector2 spriteSize;
    Vector2 position;
    public float nextSpawn;

    Vector3 cameraPosition;
    public void Start()
    {
        nextSpawn = Time.time + 5;
    }

    public void Update()
    {
        cameraPosition = Camera.transform.position;
        if (Time.time > nextSpawn)
        {
            position = new Vector2(Random.Range(cameraPosition.x + 25, cameraPosition.x + 45f), Random.Range(-1f, 5f));
            Instantiate(bird, position, Quaternion.identity);

            nextSpawn += 5;
        }
        
    }
}
