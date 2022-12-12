using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetMake : MonoBehaviour
{
    //Temporary number, will be updated with the correct number when I know how many patterns will exist in total
    //true = owned, false = not owned
    bool[] ownedPattern = new bool[50];

    private float makeTimer = 0;

    [SerializeField]
    Player player;

    [SerializeField]
    BasePattern basePattern;

    // Start is called before the first frame update
    void Start()
    {
        ownedPattern[0] = true;

        //the second one is like that since we only need the length - 1 since first one is already assigned.
        for (int i = 1; i < ownedPattern.Length - 1; i++)
        {
            ownedPattern[i] = false;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            Create(0);
        }
    }

    public void Create(int pattern)
    {
        if (ownedPattern[pattern] == true)
        {
            /*while (makeTimer <= basePattern.time)
            {
                makeTimer += 0.000001f * Time.deltaTime;
                
                Debug.Log(makeTimer);
            }
            Debug.Log("1232123231231");*/
        }
    }
}
