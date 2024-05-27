using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vectors : MonoBehaviour
{
    public float velocityLineLength = 1.0f; // Adjust the length of the velocity debug line
    float G = 6.67f;

    public double k_energy;
    public double g_energy;

    void Update()
    {
        // Get the Rigidbody component of this GameObject
        Rigidbody rb = GetComponent<Rigidbody>();

        if (rb != null)
        {

            // Get the object's current velocity and speed
            Vector3 velocity = rb.velocity;
            float speed = rb.velocity.magnitude;

            // Get the position of the game object
            Vector3 objectPosition = gameObject.transform.position;

            // Calculate the magnitude (distance from origin)
            float distanceToOrigin = objectPosition.magnitude;

            // Draw a debug line representing velocity (green)
            Debug.DrawRay(transform.position, velocity * velocityLineLength, Color.green);

            //Energy
            k_energy = 0.5 * Mathf.Pow (speed, 2) * rb.mass;
            g_energy = - G * 20 * 2000 / distanceToOrigin;

            Debug.Log("Kinetic Energy: " + k_energy);
            Debug.Log("Gravitational Energy: " + g_energy);
        }
        else
        {
            Debug.LogWarning("Rigidbody component not found. Cannot draw velocity.");
        }
    }
}
