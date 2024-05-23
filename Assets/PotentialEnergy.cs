using UnityEngine;
using UnityEngine.UI; // Import for UI elements
using static System.Math;

public class PotentialEnergy : MonoBehaviour
{
    private Rigidbody rb; // Single Rigidbody reference for clarity
    private const float G = 6.67e-11f; // Use 'const' for clarity
    public Slider potentialEnergySlider; // Reference to your slider UI element

    void Update()
    {
        Vector3 distanceVector = transform.position;
        float distance = distanceVector.magnitude;
        // Assuming 'mass' is another variable representing object's mass:
        float potentialEnergy = -G * 2000 * 20 / distance; // Calculate potential energy

        // Update slider value based on potential energy (assuming range is 0-1)
        potentialEnergySlider.value = Mathf.Clamp01(System.Math.Abs(potentialEnergy));

        // Use the calculated 'potentialEnergy' for further computations or visualization
        }
    }

