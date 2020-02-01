using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject crate;
    public Camera cam;
    public float nextSpawn2;
    Vector2 position;

    Vector3 cameraPosition;
    public void Start()
    {
        cam = FindObjectOfType<Camera>();
        nextSpawn2 = Time.time + 7;
    }

    public void FixedUpdate()
    {
        cameraPosition = cam.transform.position;
        if (Time.time > nextSpawn2)
        {
            position = new Vector2(Random.Range(cameraPosition.x + 3, cameraPosition.x + 10f), Random.Range(5, 15f));
            Instantiate(crate, position, Quaternion.identity);

            nextSpawn2 += 7;
        }

    }
}