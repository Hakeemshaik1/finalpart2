using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section;
    public int Zposition = 50;
    public int sectionCounter = 0;
    public bool CreateSection = false;
    public int secNum;

    void Update()
    {
        if (CreateSection == false)
        {
            CreateSection = true;
            StartCoroutine(GenerateSection());
        }
    }

    IEnumerator GenerateSection()
    {
        if (sectionCounter < 1)
        {
            secNum = Random.Range(0, 2); // Spawn section 0 or 1
        }
        else if (sectionCounter < 7)
        {
            secNum = 2; // Spawn section 3
        }
        else
        {
            secNum = Random.Range(0, 2); // Spawn section 0 or 1 again
        }

        GameObject newSection = Instantiate(section[secNum], new Vector3(-4, 0, Zposition), Quaternion.identity);
        newSection.transform.Rotate(-90f, 0f, 0f); // Rotate section by -90 degrees on the Y-axis
        Zposition += 50;

        yield return new WaitForSeconds(8);

        sectionCounter++;
        if (sectionCounter > 8)
        {
            sectionCounter = 0; // Reset the counter after spawning section 0 and 1 again
        }

        CreateSection = false;
    }
}
