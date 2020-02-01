using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;
    }

    void FixedUpdate()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;

        Destroy(gameObject, 5f);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bird")
        {
            other.gameObject.SetActive(false);
            Debug.Log("Bird hit crate and died");
        }
    }
}
