using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{

    private int count;
    public string name;
    public Text countText;
    private bool trigger;
    public KeyCode fireKey;
    public KeyCode trapKey;

    public GameObject trap;
    public int trapDisplacement;

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
            if (count >= 500)
            {
                count = count - 500;
                SetCountText();
            }

        }

        if (trigger && Input.GetKeyDown(fireKey))
        {
            count = count + 100;
            SetCountText();
            trigger = false;
        }
    }


    void SetCountText()
    {
        countText.text = name + " - " + count.ToString() + "$";
    }

    // Detecs player on treasure collider

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Pickup")
        {
            trigger = true;
            Debug.Log("In");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Pickup")
        {
            trigger = false;
            Debug.Log("Out");
        }
    }
}