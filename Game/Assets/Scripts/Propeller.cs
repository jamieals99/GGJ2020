using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propeller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.deltaTime > 0)
        {
            if (gameObject.name == "Bottom Propeller")
            {
                if (gameObject.GetComponent<SpriteRenderer>().flipX == false)
                {
                    gameObject.GetComponent<SpriteRenderer>().flipX = true;
                }
                else if (gameObject.GetComponent<SpriteRenderer>().flipX == true)
                {
                    gameObject.GetComponent<SpriteRenderer>().flipX = false;
                }
            }
            else if (gameObject.name == "Back Propeller")
            {
                if (gameObject.GetComponent<SpriteRenderer>().flipY == false)
                {
                    gameObject.GetComponent<SpriteRenderer>().flipY = true;
                }
                else if (gameObject.GetComponent<SpriteRenderer>().flipY == true)
                {
                    gameObject.GetComponent<SpriteRenderer>().flipY = false;
                }
            }
        }
    }
}
