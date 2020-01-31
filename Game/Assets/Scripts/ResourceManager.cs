﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceManager : MonoBehaviour
{
    private int tape, metal, wood;
    public Text tapeAmount, metalAmount, woodAmount;


    // Start is called before the first frame update
    void Start()
    {
        tape = 0;
        metal = 0;
        wood = 0;
    }

    // Update is called once per frame
    void Update()
    {
        tapeAmount.text = "" + tape;
        metalAmount.text = "" + metal;
        woodAmount.text = "" + wood;

        if (Input.GetKeyDown(KeyCode.U))
        {
            tape += 10;
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            metal += 10;
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            wood += 10;
        }
    }
}
