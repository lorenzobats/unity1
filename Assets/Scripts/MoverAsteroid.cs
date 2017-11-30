using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverAsteroid : MonoBehaviour
{

	void Start ()
	{
		GetComponent<Rigidbody> ().velocity = transform.forward * Random.Range(-5, -8);
	}
}
