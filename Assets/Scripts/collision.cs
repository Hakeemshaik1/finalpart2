using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public GameObject Player;
    public GameObject Charactermodel;
    public GameObject levelControl;

   private void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        Player.GetComponent<PlayerMove>().enabled = false;
        Charactermodel.GetComponent<Animator>().Play("Stumble Backwards");
        levelControl.GetComponent<Score>().enabled = false;
        levelControl.GetComponent<endrunsequance>().enabled = true;

    }

    

}