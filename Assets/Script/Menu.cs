using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    private string[] menu = new string[6];

    private bool chose = false;

    private bool inMenu = true;

    private int whichButton = 0;

    private int safe = 0;

    // Start is called before the first frame update
    void Start()
    {
        menu[0] = "Pets";
        menu[1] = "Bag";
        menu[2] = "Patterns";
        menu[3] = "Options";
        //Might want to have an exit and save button, and an exit button? (When we can save)
        menu[4] = "Exit";
        //This won't be in the list
        menu[5] = "BackToGame";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {


            do
            {
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    whichButton += 1;
                }

                switch (whichButton)
                {
                    case 0:
                        break;
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        inMenu = false;
                        break;
                }

            } while (inMenu == true);
        }






        //Might be easier to have an for-loop insted, but I don't have a foreach yet, so it will have to do.
        /*foreach (string menu in menu)
        {*/
        /*if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("Menu");

            do
            {

                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    if (whichButton != 5)
                    {
                        //Moves down to next button
                        whichButton += 1;
                    }
                    else
                    {
                        //Goes back up to the first one
                        whichButton = 0;
                    }

                    Debug.Log(whichButton);

                }
                else if (Input.GetKeyDown(KeyCode.Escape))
                {
                    Debug.Log("chose");
                    chose = true;
                }
                safe += 1;

            } while (chose == false && safe < 100);
        }*/
        //}
        
    }
}
