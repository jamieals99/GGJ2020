using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    private bool paused;
    public GameObject PauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        paused = false;
        PauseMenu.SetActive(false);
        Debug.Log("Test");
    }

    // Update is called once per frame
    void Update()
    {
        if((Input.GetKeyDown(KeyCode.Escape)) && (paused == false))
        {
            Debug.Log("Test2");
            paused = true;
            PauseMenu.SetActive(true);
            Time.timeScale = 0;
        }

        else if(Input.GetKeyDown(KeyCode.Escape) && paused)
        {
            Debug.Log("Test3");
            Time.timeScale = 1;
            PauseMenu.SetActive(false);
            paused = false;
        }
    }
}
