using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class endrunsequance : MonoBehaviour
{
    public GameObject liveScore;
    public GameObject EndScreen;
    public GameObject fadeout;

    void Start()
    {
        StartCoroutine(End());
    }

    IEnumerator End()
    {
        yield return new WaitForSeconds(3);
        liveScore.SetActive(false);
        EndScreen.SetActive(true);
        yield return new WaitForSeconds(3);
        fadeout.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);


    }
}
