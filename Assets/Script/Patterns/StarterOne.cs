using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarterOne : BasePattern
{
    [SerializeField]
    PetMake petMake;

    //Player player;

    //The pet (gameobject)
    [SerializeField]
    GameObject starterOne;

    // Start is called before the first frame update
    void Start()
    {
        thePet = starterOne;

        //NOT ALL THINGS HAVE BEEN ASSIGNED!

        //In seconds (All these values are temporary).
        time = 12;
        hp = 50;
        size = 0;
        //This is in gram right now, but we might want to change that to meters?
        yarnAmount = 50;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
