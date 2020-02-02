using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarpoonGun : MonoBehaviour
{
    private Vector3 screenPoint;
    public GameObject crosshair;
    public bool usingHarpoon;
    public GameObject harpoonGun;
    // Start is called before the first frame update
    void Start()
    {

        screenPoint = Input.mousePosition;
        usingHarpoon = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.deltaTime > 0 && usingHarpoon == true)
        {
            screenPoint = Input.mousePosition;
            screenPoint.z = 100; //distance of the plane from the camera
            crosshair.transform.position = Camera.main.ScreenToWorldPoint(screenPoint);
            crosshair.SetActive(true);

            var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(harpoonGun.transform.position);
            var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            if (angle > -90 && angle < 90)
            {
                harpoonGun.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            }
            
        } 
        if(usingHarpoon == false)
        {
            crosshair.SetActive(false);
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        usingHarpoon = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        usingHarpoon = false;
    }
}
