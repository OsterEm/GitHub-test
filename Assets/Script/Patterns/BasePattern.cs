using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePattern : MonoBehaviour
{
    //The gameobject for the pet that the pattern makes
    public GameObject thePet;

    //The time this pattern takes, should be different for each pattern
    public int time;

    //The health points of the pets, different for each pattern
    public int hp;

    //The defence
    public int def;

    //The attack power
    public int atk;

    //The agility/speed (Should be different or same???)
    public int agility;

    //The size of the pattern, 0 = small, 1 = medium, 2 = large
    public int size;

    //How much yarn is needed
    public int yarnAmount;

    //What kind of yarn it is
    public string yarnType;

    //Used as a timer when making pets.
    public float makeTimer;

    //Are we making a pet?
    public bool make = false;

    [SerializeField]
    public Player player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
