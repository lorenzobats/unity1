using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvasiveManuever : MonoBehaviour {

	public float dodge;
	public Vector2 startWait;
	public Vector2 maneuverTime;
	public Vector2 maneuverWait;

	private float targetManeuver;

	void Start () 
	{
		StartCoroutine (Evade ());	
	}

	IEnumerator Evade()
	{
		yield return new WaitForSeconds (Random.Range (startWait.x, startWait.y));

		while (true) {
			targetManeuver = Random.Range (1, dodge) * -Mathf.Sign (transform.position.x);
			yield return new WaitForSeconds ();
			targetManeuver = 0;
			yield return new WaitForSeconds ();
		}
	}

	//Video bei 1:19:00 min

	void Update () {
		
	}
}
