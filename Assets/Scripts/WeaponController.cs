using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour {

	private AudioSource audioScource;

	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
	public float delay;

	void Start () {

		fireRate = Random.Range (1, 2);

		audioScource = GetComponent<AudioSource> ();
		InvokeRepeating ("Fire", delay, fireRate);
	}

	void Fire ()
	{
		Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
		audioScource.Play ();
	

}
}
