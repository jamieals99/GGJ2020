using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
        private int health;
        public Text healthText;

    void Start()
    {
        health = 5;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.K) && Time.timeScale>0)
        {
            health--;
        }

        healthText.text = "HP: " + health;
        
    }
}
