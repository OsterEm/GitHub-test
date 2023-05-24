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
    public List<GameObject> pets; // = new GameObject[8];
    //How many pets
    private int countPets = -1;
    //How much space they take (Together they will only be able to take up 8 space)
    public int spacePets;

    [SerializeField]
    public GameObject[] souls = new GameObject[8];

    //Don't know what else to call them, pets that don't have a soul (but a body)
    [SerializeField]
    public List<GameObject> nonMadePets;
    //-1 because arrays/lists start at 0, and we need the first one, after adding one, to be 0
    private int countNonMadePets = -1;
    public int spaceNonMadePets;


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

    public void PutPetInBag(GameObject gameObject, GameObject yarn)
    {
        nonMadePets.Add(gameObject);
        countNonMadePets += 1;
        nonMadePets[countNonMadePets].GetComponent<BasePattern>().yarnType = yarn;
        //spaceNonMadePets += nonMadePets[countNonMadePets].GetComponent<BasePattern>().size;

        Debug.Log(yarn);
        Debug.Log(nonMadePets[countNonMadePets].GetComponent<BasePattern>().yarnType);
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

        /*if (spacePets + gameObject.GetComponent<BasePattern>().size !>= 8)
        {
            pets.Add(gameObject);
            countPets += 1;
            Debug.Log(countPets);
            spacePets += pets[countPets].GetComponent<BasePattern>().size;

            Debug.Log(countPets);
            Debug.Log("We made a pet, but please make this a loop when we know how the pet-space-thing should work");
        }
        else
        {
            Debug.Log("Can't make, not enough space");
        }*/

        //Adds the object as a pet
        pets.Add(gameObject);
        //There is one more pet
        countPets += 1;
        Debug.Log(countPets);
        //The pet takes up space
        spacePets += pets[countPets].GetComponent<BasePattern>().size;

        Debug.Log(countPets);
        Debug.Log("We made a pet, but please make this a loop when we know how the pet-space-thing should work");

        //One NonMadePet is a pet now. Also removes it from the space
        countNonMadePets -= 1;
        spaceNonMadePets -= pets[countPets].GetComponent<BasePattern>().size;



        /*if (pets.Count == 0)
        {
            //pets[0] = gameObject;
            pets.Add(gameObject);
            countPets += 1;
            Debug.Log(countPets);
            spacePets += pets[countPets].GetComponent<BasePattern>().size;

            Debug.Log(countPets);
            Debug.Log("We made a pet, but please make this a loop when we know how the pet-space-thing should work");
        }*/
    }
}
