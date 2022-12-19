using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarterOne : BasePattern
{
    [SerializeField]
    PetMake petMake;
    [SerializeField]
    Player player;

    // Start is called before the first frame update
    void Start()
    {
        //In minutes
        time = 120;
        hp = 50;
        size = 0;
        //This is in gram right now, but we might want to change that to meters?
        yarnAmount = 50;

        petMake.ownedPattern[1] = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void Create()
    {
        base.Create();
        player.PetAssign(1);
    }
}
