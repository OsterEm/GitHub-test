using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetMake : MonoBehaviour
{
    //Temporary number, will be updated with the correct number when I know how many patterns will exist in total
    //true = owned, false = not owned
    public bool[] ownedPattern = new bool[50];

    //public [] allPatterns = new bool[50];

    //Fill with all the patterns in inspector
    //public BasePattern[] patterns = new BasePattern[50];

    //The patterns that is being made
    private object thePattern;

    private float makeTimer = 0;

    private bool make = false;

    [SerializeField]
    Player player;

    [SerializeField]
    BasePattern basePattern;
    [SerializeField]
    StarterOne starterOne;

    // Start is called before the first frame update
    void Start()
    {
        //We always own the first pattern
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
        /*if (Input.GetKeyDown(KeyCode.M))
        {
            Create(0);

            thePattern = basePattern;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Create(1);

            thePattern = starterOne;
        }*/
    }
    public IEnumerable MakePet(BasePattern basePattern)
    {
        make = true;
        Debug.Log("121212121212121212121212121212");



        BasePattern pattern = basePattern.GetComponent<BasePattern>();

        yield return new WaitForSeconds(pattern.makeTimer);

        Create(pattern.number);
        Debug.Log("Pling!");
    }

    public void Create(int pattern)
    {
        Debug.Log("3333333333333333333333333333333333333333");
        if (ownedPattern[pattern] == true)
        {
            make = true;

            Debug.Log("We made it!!!");

            player.PetAssign(pattern);

            /*
            while (make == true)
            {
                makeTimer += Time.deltaTime;

                /*if (makeTimer >= thePattern.time)
                {

                }
                
                Debug.Log(makeTimer);
            }
            Debug.Log("1232123231231");*/
        }
        else
        {
            Debug.Log("Don't own that pattern.");
        }
    }
}
