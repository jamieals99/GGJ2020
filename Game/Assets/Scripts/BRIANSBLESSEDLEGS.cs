using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BRIANSBLESSEDLEGS : MonoBehaviour
{

    Animator animation;

    // Start is called before the first frame update
    void Start()
    {
       animation = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.D) && Time.deltaTime > 0)
        {
            animation.Play("brian");
        }

      // if (Input.GetKeyUp(KeyCode.D) && Time.deltaTime > 0)
       // {
       //     animation.SetTrigger("idle");
        //}
        
        if (Input.GetKey(KeyCode.A) && Time.deltaTime > 0)
        {
            animation.Play("brian");
        }
        
       // if (Input.GetKeyUp(KeyCode.A) && Time.deltaTime > 0)
       // {
        //    animation.SetTrigger("idle");
        //}
        
    }
}
