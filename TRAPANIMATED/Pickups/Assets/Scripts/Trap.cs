using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public float delay;
    private bool moveIt = false;
    private Controller moveScript;
    private Animator anim;
    private Animator anim2;
 
    public void OnTriggerEnter(Collider collider)
    {
        // Only Players can collide
        if (collider.gameObject.CompareTag("Player"))
        {
            moveScript = collider.GetComponent<Controller>();
            
            StartCoroutine(Wait(delay));
            
        }
    }

    
    IEnumerator Wait(float seconds)
    {
        
        moveScript.canMove = false;
        gameObject.GetComponent<Collider>().enabled = false;
       // gameObject.GetComponent<Renderer>().enabled = false;
        Animator anim = GetComponent<Animator>();
        anim.SetTrigger("CloseTrap");

        seconds = 5;
        yield return new WaitForSeconds(seconds);
        Animator anim2 = GetComponent<Animator>();
        anim.SetTrigger("OpenTrap");
        if (moveScript != null)
            moveScript.canMove = true;
        
        yield return new WaitForSeconds(seconds);
        gameObject.GetComponent<Collider>().enabled = true;
      //  gameObject.GetComponent<Renderer>().enabled = true;

        //Animator anim2 = GetComponent<Animator>();
        //anim.SetTrigger("OpenTrap");

    }
}
