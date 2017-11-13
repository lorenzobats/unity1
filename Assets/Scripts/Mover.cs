using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

	private int speed;

	void Start ()
	{
		speed = 20;
		GetComponent<Rigidbody> ().velocity = transform.forward * speed;
	}
}
