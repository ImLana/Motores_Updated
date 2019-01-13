using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacePickups : MonoBehaviour
{
    public GameObject Pickup;
    public Vector3 displacementFromPlaceHolder;
    public float reactivateDelay;
    private List<GameObject> InnactivePickups;
    private float lastUpdateTime;

    // Use this for initialization
    void Start()
    {
        lastUpdateTime = Time.time;

        GameObject[] placeHolders = GameObject.FindGameObjectsWithTag("Placeholder");

        InnactivePickups = new List<GameObject>();

        foreach (GameObject placeHolder in placeHolders)
        {
            GameObject thisPickup = GameObject.Instantiate(Pickup);
            thisPickup.transform.position = placeHolder.transform.position + displacementFromPlaceHolder;
            thisPickup.SetActive(false);
            InnactivePickups.Add(thisPickup);
        }

    }

    private void Update()
    {
        if (Time.time - lastUpdateTime >= reactivateDelay)
        {
            InstantiateMissingObjects();
            lastUpdateTime = Time.time + 10f;
        }
    }

    private void InstantiateMissingObjects()
    {
        foreach (GameObject thisObject in InnactivePickups)
        {
            thisObject.SetActive(true);
            InnactivePickups.Remove(thisObject);
        }
    }

    public void PickItUp(GameObject target)
    {
        InnactivePickups.Add(target);
        target.SetActive(false);

       for (int i = 0; i < InnactivePickups.Count; i++)
        {
        // Debug.Log( i + " - " + InnactivePickups[i].transform.name);
        }
    }
}
