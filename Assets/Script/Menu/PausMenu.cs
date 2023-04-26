using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject menuHolder;

    public GameObject pauseMenuUI;

    public GameObject patternMenu;

    [SerializeField]
    private EventSyst eventSyst;

    [SerializeField]
    private PetMake petMake;

    void Start()
    {
        menuHolder.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        //Temporary button? Had M before, but it is too close to Space, so sometimes I clicked the wrong button.
        //Okay, I still press the wrong button, but at least it is easier to the hand now.
        if (Input.GetKeyDown(KeyCode.E))
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
    //We SHOULD make so that if you are in a sub menu, you don't close the menu, but go back one step
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
        pauseMenuUI.SetActive(true);
        patternMenu.SetActive(false);
        Time.timeScale = 0;
        GameIsPaused = true;

        eventSyst.PauseMenu();

        Debug.Log("Testingtesting");
    }

    //All the patterns in a long list
    public void Patterns()
    {
        Debug.Log("All our patterns...");

        patternMenu.SetActive(true);
        pauseMenuUI.SetActive(false);

        eventSyst.PatternMenu();
    }

    //What happens if you press the starterOne button (There should be more sub menus:
    //1. when hovering over the button, the pet is shown to the side. 2. Click pattern. 3. Look at what you
    //need to create pattern. 4. Chose what yarn, eyes, extra things, etc, that you need. 5. Confirm.)

    //SHOULD BE ONLY ONE, BUT WITH A int i! (SO WE DON'T NEED 50+ FUNCTIONS!)
    public void StarterOne()
    {
        petMake.Create(1);
    }

    public void SendCreate(BasePattern basePattern)
    {
        Debug.Log("11111111111");
        Debug.Log(basePattern);
        petMake.MakePet(basePattern);
    }

}
