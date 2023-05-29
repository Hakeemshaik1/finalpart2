using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullMovement : MonoBehaviour
{
    private float movementSpeed;

    public void SetMovementSpeed(float speed)
    {
        movementSpeed = speed;
    }

    private void Update()
    {
        // Move the bull forward
        transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
    }
}