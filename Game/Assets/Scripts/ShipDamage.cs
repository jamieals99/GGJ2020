using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipDamage : MonoBehaviour
{

    HealthBar hp;

    private void Start()
    {
        

    }
    

    void OnTriggerEnter2D(Collider2D other)
    {
        hp = gameObject.GetComponent<HealthBar>();

        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<HealthBar>().TakeDamage(20);
            Debug.Log("Damage from Trigger box");
        }
    }
}
