using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.Linq;

public class Score : MonoBehaviour
{
    public float count;
    public Text countText;

    private bool trigger;
    private bool IsHolding;
    private bool AtRespawn;
    public KeyCode fireKey;
    public KeyCode trapKey;

    public GameObject Trap;
    public GameObject Diamond;
    public Vector3 displacementFromTrap;

    // Use this for initialization
    void Start()
    {
        count = 0;
        SetCountText();
    }

    void Update()
    {
        if (Input.GetKeyDown(trapKey))
        {
            if (count >= 500) //trap
            {
                count = count - 500;
                Instantiate(Trap, transform.position + displacementFromTrap + (transform.forward * 2), transform.rotation);
                SetCountText();
            }
        }

        if (trigger && Input.GetKeyDown(fireKey))
        {
            IsHolding = true;
            Diamond.SetActive(true);
        }

        if (IsHolding & AtRespawn && Input.GetKeyDown(fireKey))
        {
            count = count + 100;
            SetCountText();
            trigger = false;
            IsHolding = false;
            Diamond.SetActive(false);

        }
    }


    void SetCountText()
    {
        countText.text = " " + count.ToString() + "$";
    }


    // Detecs player on treasure collider

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Pickup")
        {
            trigger = true;
            // Debug.Log("In");
        }

        if (other.tag == "Respawn")
        {
            AtRespawn = true;
            Debug.Log("InRespawn");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Pickup")
        {
            trigger = false;
            // Debug.Log("Out");
        }

        if (other.tag == "Respawn")
        {
            AtRespawn = false;
            Debug.Log("OutRespawn");
        }
    }
}