﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

	public int speed;

	void Start ()
	{
		GetComponent<Rigidbody> ().velocity = transform.forward * speed;
	}
}
