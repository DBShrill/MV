using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vectors : MonoBehaviour
{
    public float velocityLineLength = 1.0f; // Adjust the length of the velocity debug line

    void Update()
    {
        // Get the Rigidbody component of this GameObject
        Rigidbody rb = GetComponent<Rigidbody>();

        if (rb != null)
        {
            // Get the object's current velocity
            Vector3 velocity = rb.velocity;

            // Draw a debug line representing velocity (green)
            Debug.DrawRay(transform.position, velocity * velocityLineLength, Color.green);
        }
        else
        {
            Debug.LogWarning("Rigidbody component not found. Cannot draw velocity.");
        }
    }
}
