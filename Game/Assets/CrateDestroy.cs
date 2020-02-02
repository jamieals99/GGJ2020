using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateDestroy : MonoBehaviour
{

    // Add this to crate to collect resources from it


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Harpoon")
        {
            // add resources OR // add maill to main deck for player tocollect

            // destroy crate
            Destroy(gameObject);
        }
    }
}
