using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ResourceManager : MonoBehaviour
{
    private int startingAmounts = 20;
    public float tape, metal, wood;
    public Text tapeAmount, metalAmount, woodAmount;
    float objectHealth;


    // Start is called before the first frame update
    void Start()
    {
        tape = startingAmounts;
        metal = startingAmounts;
        wood = startingAmounts;
        objectHealth = 0f;

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

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E) && Time.deltaTime > 0)
            {
                if (objectHealth < 100 && tape > 0.5 && metal > 0.5 && wood > 0.5)
                {
                    tape -= 0.5f;
                    metal -= 0.5f;
                    wood -= 0.5f;

                    objectHealth += 0.5f;
                    Debug.Log(objectHealth);
                }
            }
        }
    }
}
