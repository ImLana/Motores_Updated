using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScreen : MonoBehaviour
{
    public GameObject panel;

    public Text[] finalResult;
    public Text[] count;

    private float toFloatRacoon;
    private float toFloatFox;
    private float toFloatCat;
    private float toFloatCrow;

    public Text winnerRacoon;
    public Text winnerFox;
    public Text winnerCat;
    public Text winnerCrow;

    public Text draw;

    private void Update()
    {
        finalResult[0].text = "Racoon: " + count[0].text;
        finalResult[1].text = "Fox: " + count[1].text;
        finalResult[2].text = "Cat: " + count[2].text;
        finalResult[3].text = "Crow: " + count[3].text;

        toFloatRacoon = float.Parse(count[0].text);
        toFloatFox = float.Parse(count[1].text);
        toFloatCat = float.Parse(count[2].text);
        toFloatCrow = float.Parse(count[3].text);

        if (toFloatRacoon > toFloatCat)
        {
            if (toFloatRacoon > toFloatFox)
            {
                if (toFloatRacoon > toFloatCrow)
                {
                    winnerRacoon.enabled = true;
                }
            }
        }

        if (toFloatFox > toFloatRacoon)
        {
            if (toFloatFox > toFloatCat)
            {
                if (toFloatFox > toFloatCrow)
                {
                    winnerFox.enabled = true;
                }
            }
        }

        if (toFloatCat > toFloatRacoon)
        {
            if (toFloatCat > toFloatFox)
            {
                if (toFloatCat > toFloatCrow)
                {
                    winnerCat.enabled = true;
                }
            }
        }

        if (toFloatCrow > toFloatRacoon)
        {
            if (toFloatCrow > toFloatCat)
            {
                if (toFloatCrow > toFloatFox)
                {
                    winnerCrow.enabled = true;
                }
            }
        }

        if (toFloatRacoon == toFloatCat && toFloatRacoon == toFloatFox && toFloatRacoon == toFloatCrow)
        {
            draw.enabled = true;
        }

        if (toFloatCat == toFloatRacoon && toFloatCat == toFloatFox && toFloatCat == toFloatCrow)
        {
            draw.enabled = true;
        }

        if (toFloatFox == toFloatRacoon && toFloatFox == toFloatCat && toFloatFox == toFloatCrow)
        {
            draw.enabled = true;
        }

        if (toFloatCrow == toFloatRacoon && toFloatCrow == toFloatFox && toFloatCrow == toFloatCat)
        {
            draw.enabled = true;
        }

        if (panel.activeInHierarchy)
        {
            finalResult[0].enabled = true;
            finalResult[1].enabled = true;
            finalResult[2].enabled = true;
            finalResult[3].enabled = true;
        }
    }
}

