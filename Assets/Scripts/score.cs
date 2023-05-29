using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject ScoreDisplay;
    public GameObject EndScoreDisplay;
    public int Distance;
    public bool addDistance = false;



    void Start()
    {

    }

    void Update()
    {
        if (addDistance == false)
        {
            addDistance = true;
            StartCoroutine(AddDistance());
        }
    }

    IEnumerator AddDistance()
    {
        Distance += 1;
        ScoreDisplay.GetComponent<Text>().text = "" + Distance;
        EndScoreDisplay.GetComponent<Text>().text = "" + Distance;

        yield return new WaitForSeconds(0.54f);

        addDistance = false;
    }
}

    
