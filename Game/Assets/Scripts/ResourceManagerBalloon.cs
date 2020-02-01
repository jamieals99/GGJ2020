using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResourceManagerBalloon: MonoBehaviour
{

    private int startingAmount = 20;
    private float tape;
    public Text tapeAmount;
    HealthBar hp;



    // Start is called before the first frame update
    void Start()
    {
        hp = GetComponent<HealthBar>();
        tape = startingAmount;
    }

    // Update is called once per frame
    void Update()
    {
        tapeAmount.text = "" + tape;

        if (Input.GetKeyDown(KeyCode.U) && Time.timeScale > 0)
        {
            tape += 10;
        }

        if (hp.health <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && gameObject.tag == "Balloon")
        {
            if (Input.GetKey(KeyCode.E) && Time.deltaTime > 0)
            {
                if (tape > 0 && hp.health <= 100)
                {
                    hp.RepairDamage(1);
                    tape -= 1f;
                    Debug.Log("Balloon Repair");
                }
            }
        }
    }
}
