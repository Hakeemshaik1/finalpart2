using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer : MonoBehaviour
{
    public string parentName;


    void Update()
    {
        parentName = transform.name;
        StartCoroutine(Destroysection());
    }

    IEnumerator Destroysection()
    {
        yield return new WaitForSeconds(50);
        if (parentName == "SECTION2(Clone)")
        {
            Destroy(gameObject);
        }
        if (parentName == "SECTION3(Clone)")
        {
            Destroy(gameObject);
        }
        if (parentName == "startsection")
        {
            Destroy(gameObject);
        }
        if (parentName == "SECTION4(Clone)")
        {
            Destroy(gameObject);
        }


    }
}
