using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    

    private PlacePickups Manager;
    private bool racoonCol;
    private bool foxCol;
    private bool crowCol;
    private bool catCol;

    private void Start()
    {
        Manager = GameObject.FindGameObjectWithTag("Manager").GetComponent<PlacePickups>();
    }
    //Defining when the Player is Colliding with the Pick Up

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Enter");
        if (other.tag == "Racoon")
            racoonCol = true;
        if (other.tag == "Fox")
            foxCol = true;
        if (other.tag == "Crow")
            crowCol = true;
        if (other.tag == "Cat")
            catCol = true;
    }

    private void OnTriggerExit(Collider other)
    {
        // Debug.Log("Exit");
        if (other.tag == "Racoon")
            racoonCol = false;
        if (other.tag == "Fox")
            foxCol = false;
        if (other.tag == "Crow")
            crowCol = false;
        if (other.tag == "Cat")
            catCol = false;
    }


    private void Update()
    {
        // if player uses the firekey and Is colliding then they well pick up the ite´m

        if (Input.GetKeyDown(KeyCode.V) && racoonCol)
        {
            Manager.PickItUp(transform.gameObject);
            racoonCol = false;
        }
        if (Input.GetKeyDown(KeyCode.RightControl) && foxCol)
        {
            Manager.PickItUp(transform.gameObject);
            foxCol = false;
        }

        if (Input.GetKeyDown(KeyCode.Joystick1Button10) && catCol)
        {
            Manager.PickItUp(transform.gameObject);
            catCol = false;
        }

        if (Input.GetKeyDown(KeyCode.Joystick2Button0) && crowCol)
        {
            Manager.PickItUp(transform.gameObject);
            crowCol = false;
        }
    }

}
