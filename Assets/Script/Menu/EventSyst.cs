using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EventSyst : MonoBehaviour
{
    //The first button in the menu menu
    [SerializeField]
    private GameObject firstMenu;

    //The first button in the pattern menu
    [SerializeField]
    private GameObject firstPattern;

    [SerializeField]
    private GameObject firstYarn;

    [SerializeField]
    private GameObject firstSoul;

    [SerializeField]
    private GameObject firstNonMade;


    EventSystem eventSystem;

    // Start is called before the first frame update
    void Start()
    {
        eventSystem = EventSystem.current;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Used in case the pause menu is closed "incorrectly" (with the m button while in a sub)
    public void PauseMenu()
    {
        //var eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject(firstMenu, new BaseEventData(eventSystem));
    }
    //The pattern menu's first button need to be selected
    public void PatternMenu()
    {
        //var eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject(firstPattern, new BaseEventData(eventSystem));
    }
    public void YarnMenu()
    {
        //var eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject(firstYarn, new BaseEventData(eventSystem));
    }

    public void SoulMenu()
    {
        eventSystem.SetSelectedGameObject(firstSoul, new BaseEventData(eventSystem));
    }

    public void NonMadePetsMenu()
    {
        eventSystem.SetSelectedGameObject(firstNonMade, new BaseEventData(eventSystem));
    }
}
