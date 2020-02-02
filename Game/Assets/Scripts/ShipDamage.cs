using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipDamage : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bird")
        {
            GetComponentInParent<HealthBar>().TakeDamage(10);
            other.gameObject.SetActive(false);
            //Debug.Log("Damage from Trigger box");
        }
    }
}
