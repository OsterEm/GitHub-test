using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed = 3;

    //Do we own the pattern?
    public bool[] ownedPatterns = new bool[10];
    //All the patterns, whether we own them or not
    public GameObject[] patterns = new GameObject[10];

    //For interacting with objects use triggers (?)

    //Array for pets that the player has. Can have, 3 small [0, 0-2], 2 medium [1, 0-1], 1 large [2,1].
    //The other spaces need to be made unavailable.
    //[SerializeField]
    //public object[,] pets = new object[3,3];

    //Could be: small takes one space, medium two spaces, and large three spaces (or something like that
    //But it doesn't really make any sense, since a large one won't take up the space in your pockets)
    [SerializeField]
    public GameObject[] pets = new GameObject[8];

    [SerializeField]
    public List<GameObject> yarn;

    //Temp. number
    [SerializeField]
    private GameObject[] allYarns = new GameObject[10];

    //All the patterns the players own, shouldn't exist 100, but it is set to that for now.
    //This is in another script called PetMake.
    //private object[] patterns = new object[100];

    [SerializeField]
    private PetMake petMake;

    [SerializeField]
    private BasePattern basePattern;
    [SerializeField]
    private StarterOne starterOne;

    // Start is called before the first frame update
    void Start()
    {
        //Temp.
        yarn.Add(allYarns[0]);
    }

    // Update is called once per frame
    void Update()
    {

        /*pets[1, 2] = null;
        pets[2, 1] = null;
        pets[2, 2] = null;*/

        //Movement
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, speed, 0)*Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 0, 180);

            //Don't want this every frame, but still need it somewhere
            //Debug.Log(pets[0, 0]);

        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, speed, 0)*Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 0, 0);

        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed, 0, 0)*Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 0, -90);

        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(speed, 0, 0)*Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 0, 90);

        }
       
        //interacting

    }

    //Trigger, could use it with doors and NPC's who stand still, and if walking in "tall grass".
    private void OnTriggerEnter2D(Collider2D other)
    {


        if (other.tag == "Door")
        {
            Debug.Log("Yay!");

            //Yes, we currently recieve the first pattern from a door
            petMake.ownedPattern[0] = true;
        }

    }
    public void PetAssign(GameObject gameObject)
    {
        /*if (pattern == 0)
        {

        }
        else if (pattern == 1)
        {
            Debug.Log("Work!");

            if (pets[0,0] == null)
            {
                pets[0, 0] = starterOne.thePet;

                Debug.Log("A new pet was made");
            }
        }*/

        //If we chose to have different space taking, then you might want some kind of if-statement like
        //if pets[0] != null, check pets[0].size, if pets[0].size = 1, check on pets[1] next, but if it is 2
        //then check on pets[2] instead (could technically just add the size to the number that checks (?))

        if (pets[0] == null)
        {
            pets[0] = gameObject;
            Debug.Log("We made a pet, but please make this a loop when we know how the pet-space-thing should work");
        }
    }
}
