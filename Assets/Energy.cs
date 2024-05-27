using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Energy : MonoBehaviour
{
    public Text energyText;
    private Vectors vectors; // Use private for encapsulation

    void Start()
    {
        vectors = GetComponent<Vectors>(); // Get the Vectors component
    }

    void Update()
    {
        if (vectors != null && vectors.k_energy != null) // Check for valid references
        {
            energyText.text = "Kinetic Energy: " + vectors.k_energy.ToString("F2") + "\n" + "Gravitional Energy: " + vectors.g_energy.ToString("F2");
        }
        else
        {
            Debug.LogError("Vectors component not found or k_energy is null!");
        }
    }
}
