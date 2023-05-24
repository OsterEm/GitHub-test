using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePattern : MonoBehaviour
    //Make abstract, or is it used (is it the basic one to catch them?)
{
    //The gameobject for the pet that the pattern makes
    public GameObject thePet;

    //The number of the pattern
    public int number;

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
    public GameObject yarnType;

    //The soul of the pet, is not assigned in the inspector since it is assigned when the player gives it a soul
    public GameObject soul;

    //Used as a timer when making pets.
    public float makeTimer;

    //Are we making a pet?
    public bool make = false;

    [SerializeField]
    public Player player;

    public PetMake petMake;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void Reference()
    {
        //petMake = FindObjectOfType<PetMake>();
    }

    //We don't need this (for now) in any of the other patterns, since it is the same (different number)
    //It is here because we need the gameobject and time of it, and check space before the coroutine
    public virtual void Make(GameObject yarn)
    {
        Debug.Log("HELLUUUU");

        //Finds PetMake (does it here since they (the patterns) are prefabs)
        petMake = FindObjectOfType<PetMake>();
        player = FindObjectOfType<Player>();

        //Checks if there is enough space (max space is right now eight)
        if (player.spaceNonMadePets + size <= 8)
        {
            player.spaceNonMadePets += size;
            //Starts the coroutine, with the patterns gameobject and time (to make it)
            petMake.StartCoroutine(petMake.MakePet(gameObject, time, yarn));

        }
        else
        {
            Debug.Log("Sot enough space");
        }

    }

}
