using UnityEngine;
using System.Collections;

public class BoltMover : MonoBehaviour 
{
	public int boltSpeed;

	private Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody> ();
		rb.velocity = transform.forward * boltSpeed;
	}


}