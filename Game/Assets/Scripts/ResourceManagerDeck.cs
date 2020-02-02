using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ResourceManagerDeck : MonoBehaviour
{

    private int startingAmount = 20;
    public float metal;
    public Text  metalAmount;
    HealthBar hp;

    // Start is called before the first frame update
    void Start()
    {
        hp = GetComponent<HealthBar>();
        metal = startingAmount;
    }

    // Update is called once per frame
    void Update()
    {
        metalAmount.text = "" + metal;

        if (Input.GetKeyDown(KeyCode.I) && Time.timeScale > 0)
        {
            metal += 10;
        }

        if (hp.health <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && gameObject.tag == "Deck")
        {
            if (Input.GetKey(KeyCode.E) && Time.deltaTime > 0)
            {
                if (metal > 0 && hp.health <= 100)
                {
                    hp.RepairDamage(1);
                    metal -= 1f;
                    //Debug.Log("Deck Repair");
                }
            }
        }
    }
}
