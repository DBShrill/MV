using UnityEngine;

public class PotentialEnergy : MonoBehaviour
{
    private Rigidbody rb; // Single Rigidbody reference for clarity
    private const float GravitationalConstant = 6.67e-11f; // Use 'const' for clarity

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Get Rigidbody component
    }

    void Update()
    {
        if (rb != null) // Check if Rigidbody exists before calculations
        {
            Vector3 distanceVector = transform.position;
            float distance = distanceVector.magnitude;

            // Assuming 'mass' is another variable representing object's mass:
            float potentialEnergy = -GravitationalConstant * rb.mass / distance; // Calculate potential energy

            // Use the calculated 'potentialEnergy' for further computations or visualization
        }
        else
        {
            Debug.LogError("PotentialEnergy script requires a Rigidbody component on the GameObject!");
        }
    }
}
