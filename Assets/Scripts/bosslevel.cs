using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BullSpawner : MonoBehaviour
{
    public GameObject bullPrefab;
    public float spawnInterval = 10f;
    public float movementSpeed = 5f;
    public float spawnMinX = -14f;
    public float spawnMaxX = -5f;

    private void Start()
    {
        StartCoroutine(SpawnBulls());
    }

    private IEnumerator SpawnBulls()
    {
        while (true)
        {
            float spawnX = Random.Range(spawnMinX, spawnMaxX);
            Vector3 spawnPosition = new Vector3(spawnX, transform.position.y, transform.position.z);
            GameObject newBull = Instantiate(bullPrefab, spawnPosition, Quaternion.identity);
            BullMovement bullMovement = newBull.GetComponent<BullMovement>();
            if (bullMovement != null)
            {
                bullMovement.SetMovementSpeed(movementSpeed);
            }

            yield return new WaitForSeconds(spawnInterval);
        }
    }
}






