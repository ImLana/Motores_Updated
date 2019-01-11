using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public KeyCode fireKey;

    private PlacePickups Manager;
    private bool isColliding;

    private void Start()
    {
        Manager = GameObject.FindGameObjectWithTag("Manager").GetComponent<PlacePickups>();
    }
    //Defining when the Player is Colliding with the Pick Up

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Enter");
        if (other.tag == "Player")
            isColliding = true;
    }

    private void OnTriggerExit(Collider other)
    {
       // Debug.Log("Exit");
        if (other.tag == "Player")
            isColliding = false;
    }


    private void Update()
    {
        // if player uses the firekey and Is colliding then they well pick up the ite´m

        if (Input.GetKeyDown(fireKey) && isColliding)
        {
            Manager.PickItUp(transform.gameObject);
            isColliding = false;

        }

    }

}
