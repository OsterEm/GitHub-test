using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject menuHolder;

    public GameObject pauseMenuUI;

    public GameObject patternMenu;

    public GameObject yarnMenu;

    public GameObject soulMenu;

    public GameObject nonMadePetsMenu;

    //Which pattern we will make
    private int whichPattern;

    [SerializeField]
    private EventSyst eventSyst;

    [SerializeField]
    private PetMake petMake;

    [SerializeField]
    private Player player;

    //[SerializeField]
    //private List<GameObject> buttonList;

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
        yarnMenu.SetActive(false);
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

    public void Souls()
    {
        soulMenu.SetActive(true);
        pauseMenuUI.SetActive(false);

        eventSyst.SoulMenu();
    }

    public void UseSoul(GameObject gameObject)
    {
        nonMadePetsMenu.SetActive(true);

        //Have something similar to when we make a pet (?)
        //ALSO; THESE ARE NOT ASSIGNED IN THE INSPECTOR! PLEASE FIX THAT! :)
    }

    //Pick which pattern (with a button in the pattern menu)
    public void ChosePattern(int index)
    {
        Debug.Log("Yarn!");

        //Hides patternMenu, and shows yarnMenu
        patternMenu.SetActive(false);
        yarnMenu.SetActive(true);

        eventSyst.YarnMenu();

        //The pattern we pick is saved in this variable
        whichPattern = index;
    }

    //Because we need the parameter
    public void YarnPress(GameObject yarn)
    {
        //Needs to make sure that it also sends the yarn, possibly by having an array and maybe YarnPress(int)
        OwnCheck(whichPattern, yarn);
    }

    //What happens if you press the starterOne button (There should be more sub menus:
    //1. when hovering over the button, the pet is shown to the side. 2. Click pattern. 3. Look at what you
    //need to create pattern. 4. Chose what yarn, eyes, extra things, etc, that you need. 5. Confirm.)

    //SHOULD BE ONLY ONE, BUT WITH A int i! (SO WE DON'T NEED 50+ FUNCTIONS!)
    /*public void StarterOne()
    {
        petMake.Create(1);
    }*/

    /*public void SendCreate(int i)
    {
        Debug.Log("11111111111");
        Debug.Log(i);
        petMake.MakePet(i);
    }*/

    //Button is clicked, and it sends a number here
    public void OwnCheck(int index, GameObject yarn)
    {
        //THIS doesn't work since it isn't the only child (there are others under CANVAS).
        //How we can fix this (Best thing I can think of right now): Make an array with all the 
        //buttons, and then do the same thing, but with the index in the array using Array.IndexOf(array, value);
        //int index = transform.GetSiblingIndex();
        //int index = buttonList.IndexOf()

        //If we own the pattern
        if (petMake.ownedPattern[index] == true)
        {
            Debug.Log(index);

            //Sends it to the Make() function of the pattern that is on the "index" place of patterns (in player)
            player.patterns[index].GetComponent<BasePattern>().Make(yarn);
        }
        //If we don't own the pattern
        else
        {
            Debug.Log("Don't own that pattern");
        }
        
    }

}
