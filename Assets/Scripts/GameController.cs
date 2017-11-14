using System.Collections;
using UnityEngine;

public class GameController : MonoBehaviour
{
	public GameObject[] hazards;
	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;


	public GUIText scoreText;
	public GUIText restartText;
	public GUIText gameOverText;
	public GUIText newWave;
	public GUIText waveCount;
	public GUIText totalScore;

	private bool gameOver;
	private bool restart;
	public int score;
	private float gameOverTime;
	private float showMessageTime;
	private float targetScore = 100;
	private float timeShown = 0f;
	private float timeToShow;
	public int endScore;
	public float totalScoreCount;



	void Start ()
	{
		gameOver = false;
		restart = false;
		score = 0;
		UpdateScore ();
		StartCoroutine (SpawnWaves ());
		gameOverTime = 7;
		endScore = 0;
		totalScoreCount = 0f;


	}

	void Update ()
	{
		if (restart) {
			if (Input.GetKeyDown (KeyCode.R)) {
				Application.LoadLevel (Application.loadedLevel);
			}
		}
			

		if (gameOver) {		
			gameOverTime -= Time.deltaTime;

			if (gameOverTime < 0) {
				restartText.text = "Press 'R' for Restart";
				restart = true;

			}
		}

		if (score >= targetScore) 
		{
			targetScore += 100;
			hazardCount += 5;
			waveWait += 0.37f;
			StartCoroutine (ShowMessage (newWave.text, timeToShow = 3));
			Debug.Log ("hazard Increased");
		}




				
	}

	IEnumerator ShowMessage(string message, float timeToShow = 3)
	{
		
		newWave.text = "Hazards increased!";

		timeShown = 0f;

		while (timeShown < timeToShow) {

			timeShown += Time.deltaTime;
			yield return null;
		}

		newWave.text = "";




	}


	IEnumerator SpawnWaves ()
	{
		yield return new WaitForSeconds (startWait);
		while (true)
		{
			for (int i = 0; i < hazardCount; i++)
			{
				GameObject hazard = hazards [Random.Range (0, hazards.Length)];
				Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (hazard, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (spawnWait);
			}
			endScore += 1;
			totalScoreCount = score / endScore;
			yield return new WaitForSeconds (waveWait);

		}
	}




	public void AddScore (int newScoreValue)
	{
		score += newScoreValue;
		UpdateScore ();

	}

	void UpdateScore ()
	{
		scoreText.text = "Score:" + score;
	}
		
		
	public void GameOver ()
	{
		gameOverText.text = "Game Over!";
		waveCount.text = "Your Wave Count:" + endScore;
		totalScore.text = "Your Total Score:" + totalScoreCount;
		gameOver = true;
	}


		
}


