﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BirdMovement : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 6f;
    }

    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        Destroy(gameObject, 5f);
    }
}

