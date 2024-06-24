using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{
    // Variables to control the movement
    public float speed = 2.0f; // Speed of the movement
    public float height = 1.0f; // Height of the oscillation

    // Original position of the arrow
    private Vector3 originalPosition;

    void Start()
    {
        // Save the original position of the arrow
        originalPosition = transform.position;
    }

    void Update()
    {
        // Calculate the new Y position
        float newY = originalPosition.y + Mathf.Sin(Time.time * speed) * height;

        // Set the new position of the arrow
        transform.position = new Vector3(originalPosition.x, newY, originalPosition.z);
    }
}
