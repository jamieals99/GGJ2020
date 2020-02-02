using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;

    //GameObject tape;
    //GameObject metal;
    //GameObject wood;


    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;
        //tape = GameObject.FindGameObjectWithTag("Balloon");
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

       /* if (other.gameObject.tag == "Harpoon")
        {
            // add resources OR // add maill to main deck for player tocollect
            tape.GetComponent<ResourceManagerBalloon>().tape += 10;


            // destroy crate
            Destroy(gameObject);
        }*/
    }
}
