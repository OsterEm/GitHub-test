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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Used in case the pause menu is closed "incorrectly" (with the m button while in a sub)
    public void PauseMenu()
    {
        var eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject(firstMenu, new BaseEventData(eventSystem));
    }
    //The pattern menu's first button need to be selected
    public void PatternMenu()
    {
        var eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject(firstPattern, new BaseEventData(eventSystem));
    }
}
