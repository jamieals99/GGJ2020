using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ResourceManagerHull : MonoBehaviour
{

    private int startingAmount = 20;
    private float wood;
    public Text woodAmount;
    HealthBar hp;

    // Start is called before the first frame update
    void Start()
    {
        hp = GetComponent<HealthBar>();
        wood = startingAmount;
        wood = startingAmount;
    }

    // Update is called once per frame
    void Update()
    {
        woodAmount.text = "" + wood;

        if (Input.GetKeyDown(KeyCode.O) && Time.timeScale > 0)
        {
            wood += 10;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && gameObject.tag == "Hull")
        {
            if (Input.GetKey(KeyCode.E) && Time.deltaTime > 0)
            {
                if (wood > 0 && hp.health <= 100)
                {
                    hp.RepairDamage(1);
                    wood -= 1f;
                    Debug.Log("Hull Repair");
                }
            }
        }
    }
}
