using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MianaTrying : MonoBehaviour
{
    public int score = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Pickup")
        {
            score = score + 10;
            Debug.Log(score);
        }
    }
}
