using UnityEngine;

public class Gforce : MonoBehaviour {

	float radius;
	Rigidbody rg,rb;
	public Vector3 forcee;
    public Vector3 distanceV;

	void Start()
	{
        rg = GetComponent<Rigidbody> ();
		radius = rg.mass*6 / 10;
	}

	void FixedUpdate()
	{
		
		Collider[] Planets = Physics.OverlapSphere(transform.position, radius);

		foreach(Collider hit in Planets)
		{
			if (hit.gameObject != this.gameObject) {				
				Vector3 distanceV = this.transform.position - hit.gameObject.transform.position;
				float distance = distanceV.magnitude;
				rb = hit.gameObject.GetComponent<Rigidbody> ();
				Vector3 forcee = (rg.mass + rb.mass / Mathf.Pow (distance, 2)) * distanceV.normalized;
				rb.AddForce (forcee);

                Debug.DrawRay(transform.position, -distanceV * 0.5f, Color.blue);  // Adjust factor to control arrow length
			}
		}
	}

}