using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour
{
	public GameObject explosion;
	public GameObject playerExplosion;
	private int scoreValue;
	private GameController gameController;




	void Start ()
	{
		

		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if (gameControllerObject != null)
		{
			gameController = gameControllerObject.GetComponent <GameController>();

		}
		if (gameController == null)
		{
			Debug.Log ("Cannot find 'GameController' script");
		}
			
	}


	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Boundary" || other.tag == "Enememy")
		{
			return;
		}
			
		scoreValue = 10;


		if (explosion != null) 
		{

			Instantiate (explosion, transform.position, transform.rotation);
		}

		if (other.tag == "Player")
		{


				Instantiate (playerExplosion, other.transform.position, other.transform.rotation);
				scoreValue -= 10;
				gameController.GameOver ();

		}
		gameController.AddScore (scoreValue);
		Destroy(other.gameObject);
		Destroy(gameObject);
	
	}
}