using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed;
    bool inLadder;
    bool inBottomPlatform;

    
    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;
        gameObject.GetComponent<Rigidbody2D>().freezeRotation = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D) && Time.deltaTime > 0)
        {
            
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A) && Time.deltaTime > 0)
        {

            transform.position += Vector3.left * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W) && inLadder && Time.deltaTime > 0)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S) && inLadder && !inBottomPlatform && Time.deltaTime > 0)
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
      if (other.gameObject.tag == "Ladder")
        {
            inLadder = true;
        }

      if(other.gameObject.tag == "Bottom Platform")
        {
            inBottomPlatform = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ladder")
        {
            inLadder = false;
        }
        if (other.gameObject.tag == "Bottom Platform")
        {
            inBottomPlatform = false;
        }
    }
}
