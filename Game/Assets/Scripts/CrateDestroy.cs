using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateDestroy : MonoBehaviour
{

    // Add this to crate to collect resources from it
    GameObject tape;
    GameObject metal;
    GameObject wood;

    // Start is called before the first frame update
    void Start()
    {
        tape = GameObject.FindGameObjectWithTag("Balloon");
        metal = GameObject.FindGameObjectWithTag("Deck");
        wood = GameObject.FindGameObjectWithTag("Hull");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Harpoon")
        {
            // add resources OR // add maill to main deck for player tocollect
            tape.GetComponent<ResourceManagerBalloon>().tape += 15;
            metal.GetComponent<ResourceManagerDeck>().metal += 10;
            wood.GetComponent<ResourceManagerHull>().wood += 20;


            // destroy crate
            Destroy(gameObject);
        }
    }
}
