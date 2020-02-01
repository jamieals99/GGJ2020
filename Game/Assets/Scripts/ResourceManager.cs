﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ResourceManager : MonoBehaviour
{
    private int startingAmounts = 20;
    public int tape, metal, wood;
    public Text tapeAmount, metalAmount, woodAmount;


    // Start is called before the first frame update
    void Start()
    {
        tape = startingAmounts;
        metal = startingAmounts;
        wood = startingAmounts;
    }

    // Update is called once per frame
    void Update()
    {
        tapeAmount.text = "" + tape;
        metalAmount.text = "" + metal;
        woodAmount.text = "" + wood;

        if (Input.GetKeyDown(KeyCode.U) && Time.timeScale > 0)
        {
            tape += 10;
        }

        if (Input.GetKeyDown(KeyCode.I) && Time.timeScale > 0)
        {
            metal += 10;
        }

        if (Input.GetKeyDown(KeyCode.O) && Time.timeScale > 0)
        {
            wood += 10;
        }
    }
}
