using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    private bool paused;
    public GameObject PauseMenu;
    public GameObject TutScreen;

    // Start is called before the first frame update
    void Start()
    {
        paused = false;
        TutScreen.SetActive(true);
        PauseMenu.SetActive(false);
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if((Input.GetKeyDown(KeyCode.Escape)) && (paused == false) && (Time.timeScale > 0))
        {
            paused = true;
            PauseMenu.SetActive(true);
            Time.timeScale = 0;
        }

        else if(Input.GetKeyDown(KeyCode.Escape) && (paused == true) && (Time.timeScale <= 0))
        {
            Time.timeScale = 1;
            PauseMenu.SetActive(false);
            paused = false;
        }
    }
}
