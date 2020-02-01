using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crate2Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 8f;
    }

    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        Destroy(gameObject,4f);
    }
}
