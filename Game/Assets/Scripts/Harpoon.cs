using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harpoon : MonoBehaviour
{
    Vector3 shootDirection;
    float speed;
    bool fired;
    public Camera cam;
    public GameObject harpoon;
    

    // Start is called before the first frame update
    void Start()
    {
        speed = 10f;
        fired = false;
        cam = FindObjectOfType<Camera>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0) && fired == false)
        {
            fired = true;
            transform.parent = null;
            shootDirection = Input.mousePosition;
            shootDirection.z = 0.0f;
            shootDirection = Camera.main.ScreenToWorldPoint(shootDirection);
            shootDirection = shootDirection - transform.position;
            gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(shootDirection.x * speed, shootDirection.y * speed, 0);
        }
        else if (Input.GetMouseButtonDown(0) && fired == true)
        {
            transform.parent = harpoon.transform;
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            gameObject.GetComponent<Rigidbody2D>().angularVelocity = 0f;
            gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
            harpoon.transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.rotation = Quaternion.Euler(0, 0, -43);
            transform.position = new Vector3(cam.transform.position.x - 2.5f, cam.transform.position.y - 1f, 0);
            fired = false;
        }
    }

}
