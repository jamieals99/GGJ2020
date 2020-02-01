using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crate2Spawn : MonoBehaviour
{
    public GameObject crate2;
    public Camera cam;
    public float nextSpawn2;
    Vector2 position;

    Vector3 cameraPosition;
    public void Start()
    {
        cam = FindObjectOfType<Camera>();
        nextSpawn2 = Time.time + 6;
    }

    public void FixedUpdate()
    {
        cameraPosition = cam.transform.position;
        if (Time.time > nextSpawn2)
        {
            position = new Vector2(Random.Range(cameraPosition.x + 20, cameraPosition.x + 25f), Random.Range(-5, 5f));
            Instantiate(crate2, position, Quaternion.identity);

            nextSpawn2 += 6;
        }

    }
}
