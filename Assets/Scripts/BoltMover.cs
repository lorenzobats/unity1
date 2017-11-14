using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltMover : MonoBehaviour {

	public class Mover : MonoBehaviour
	{

		public int speed;

		void Start ()
		{
			speed = 20;
			GetComponent<Rigidbody> ().velocity = transform.forward * speed;
		}
	}
}
