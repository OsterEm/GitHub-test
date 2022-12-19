using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed = 3;

    //For interacting with objects use triggers (?)

    //Array for pets that the player has. Can have, 3 small [0, 0-2], 2 medium [1, 0-1], 1 large [2,1].
    //The other spaces need to be made unavailable.
    public object[,] pets = new object[3,3];

    //All the patterns the players own, shouldn't exist 100, but it is set to that for now.
    //This is in another script called PetMake.
    //private object[] patterns = new object[100];

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        pets[1, 2] = null;
        pets[2, 1] = null;
        pets[2, 2] = null;

        //Movement
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, speed, 0)*Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 0, 180);

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
        }

    }
    public void PetAssign(int pattern)
    {
        if (pattern == 0)
        {

        }
        else if (pattern == 1)
        {
            if (pets[0,0] != null)
            {
                //pets[0,0] = 
            }
        }
    }
}
