using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorAsteroid : MonoBehaviour
{
	

	void Start ()
	{
		GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * Random.Range(4, 6);
	}
}

