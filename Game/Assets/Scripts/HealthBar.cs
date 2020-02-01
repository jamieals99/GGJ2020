﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public float health = 100f;
    [Header("Unity Stuff")]
    public Image healthBar;
    public float startHealth = 100;


    private void Start()
    {
        health = startHealth;
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        healthBar.fillAmount = health / startHealth;

        if (health<=0)
        {
            Debug.Log("DEAD");
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H) && Time.timeScale > 0)
        {
            TakeDamage(10f);
        }

        if (Input.GetKeyDown(KeyCode.J) && Time.timeScale > 0)
        {
            TakeDamage(20f);
        }
    }
}