using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.attachedRigidbody.isKinematic = true;
            other.attachedRigidbody.gravityScale = 0.0f;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.attachedRigidbody.isKinematic = true;
            other.attachedRigidbody.gravityScale = 0.0f;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.attachedRigidbody.isKinematic = false;
            other.attachedRigidbody.gravityScale = 1;
        }
    }
}
