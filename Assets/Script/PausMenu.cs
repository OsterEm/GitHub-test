using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject menuHolder;

    public GameObject pauseMenuUI;

    public GameObject patternMenu;

    void Start()
    {
        menuHolder.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (GameIsPaused == true)
            {
                Resume();

                Debug.Log("123");
            }
            else
            {
                Pause();

                Debug.Log("321");
            }
        }
    }
    public void Resume()
    {
        menuHolder.SetActive(false);
        Time.timeScale = 1;
        GameIsPaused = false;

        Debug.Log("Hellu");
    }

    void Pause()
    {
        menuHolder.SetActive(true);
        patternMenu.SetActive(false);
        Time.timeScale = 0;
        GameIsPaused = true;

        Debug.Log("Testingtesting");
    }

    public void Patterns()
    {
        Debug.Log("All our patterns...");

        patternMenu.SetActive(true);
        pauseMenuUI.SetActive(false);
    }

}
