using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    Vector3 screenPoint = Input.mousePosition;
    bool Harpoon;
    public GameObject crosshair;
    // Start is called before the first frame update
    void Start()
    {
        Harpoon = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Harpoon == true)
        {
            crosshair.SetActive(true);
        }
        else if (Harpoon == false)
        {
            crosshair.SetActive(false);
        }
        screenPoint = Input.mousePosition;
        screenPoint.z = 100; //distance of the plane from the camera
        crosshair.transform.position = Camera.main.ScreenToWorldPoint(screenPoint);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Harpoon = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Harpoon = false;
    }
}
