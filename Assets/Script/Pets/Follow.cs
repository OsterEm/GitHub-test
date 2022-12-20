using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    //Player
    [SerializeField]
    Player player;

    //This should be in another script,  like the pattern one, but it is here for now.
    private int size = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //The pet should not move when game is paused
        if(size == 3 && PausMenu.GameIsPaused == false)
        {
            if (Input.GetKey(KeyCode.W))
            {
                //the new vector is there for a space between player and pet
                transform.position = player.transform.position + new Vector3(0, -1.5f, 0);
                transform.rotation = Quaternion.Euler(0, 0, 180);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                //the new vector is there for a space between player and pet
                transform.position = player.transform.position + new Vector3(0, 1.5f, 0);
                //Rotates
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                //the new vector is there for a space between player and pet
                transform.position = player.transform.position + new Vector3(-1.5f, 0, 0);
                transform.rotation = Quaternion.Euler(0, 0, -90);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                //the new vector is there for a space between player and pet
                transform.position = player.transform.position + new Vector3(1.5f, 0, 0);
                transform.rotation = Quaternion.Euler(0, 0, 90);
            }
            Debug.Log("123");
            //the new vector is there for a space between player and pet
            //transform.position = player.transform.position + new Vector3(1, 1, 0);
        }
    }
}
