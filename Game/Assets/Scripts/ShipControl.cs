using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControl : MonoBehaviour
{
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
   
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.W) && Time.deltaTime > 0)
            {
                transform.position += Vector3.up * speed * Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.S) &&  Time.deltaTime > 0)
            {
                transform.position += Vector3.down * speed * Time.deltaTime;
            }
        }
    }
}
