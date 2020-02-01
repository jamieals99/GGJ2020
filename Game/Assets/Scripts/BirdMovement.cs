using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    public float speed = 750;
    /*
    Vector3 offset = new Vector3(20, 0, 0);
    public float distance = Vector3.Distance(GameObject.Find("bird101").transform.position, GameObject.Find("bird101(Clone)").transform.position);
    public float distance2 = Vector3.Distance(GameObject.Find("bird101(Clone)").transform.position, GameObject.Find("bird101(Clone)").transform.position);
    */
    // Start is called before the first frame update
    public void Start()
    {
        /*
        if(distance <= 20)
        {
            transform.position += offset;
        }
        if(distance2 <= 20)
        {
            transform.position += offset;
        }
        */
    }

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}

