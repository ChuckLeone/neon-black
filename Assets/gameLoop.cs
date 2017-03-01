using UnityEngine;
using System.Collections;

public class gameLoop : MonoBehaviour {

	[SerializeField] private GameObject ball;
	[SerializeField] private GameObject droid;
	[SerializeField] private GameObject startBox;
	[SerializeField] private GameObject startMusic;
	[SerializeField] private GameObject gameLevel;
	[SerializeField] private GameObject warpPlane;
	[SerializeField] public AudioSource source;
	[SerializeField] public AudioClip activateSound;

	[SerializeField] public GameObject activateBlueLight;
	[SerializeField] public GameObject activatePinkLight;
	[SerializeField] public GameObject activateGreenLight;
	[SerializeField] public GameObject activateYellowLight;
	//[SerializeField] public GameObject Score;
//	[SerializeField] public TextMesh updateScore;


	public int playerScore = 0;
	public int cpuScore = 0;
	public float speed = 1000f;
	public scoreBoard updateScoreboard;
	private GameObject startButton;
	public int gameState = 0;
	public Rigidbody ballTarget;
	public Rigidbody cubeTarget;
	public Rigidbody enemy;

	int numTargets = 20;

	// Use this for initialization
	public void Start () {
		gameState = 0;
		startButton = GameObject.Find ("StartSwitch");
		startButton.transform.position = new Vector3(10, 5, -85);
		startBox.SetActive (true);
		gameLevel.SetActive (false);
		startMusic.SetActive (false);
		source = GetComponent<AudioSource>();
		//updateScore = GetComponent<TextMesh>();
		//updateScore.text = playerScore.ToString ();
		updateScore();
	}

	// Update is called once per frame
	void Update () {
		//gamestate
		if(gameState == 0) {
			
		}

		if(gameState == 1) {
			if(numTargets <= 0) {
				Invoke ("spawnTargets", 2);
			}
		}

		if(gameState == 2) {
		}

		if(cpuScore == 1) {
			activateBlueLight.SetActive (true);
		}

		if(cpuScore == 2) {
			activateYellowLight.SetActive (true);
		}

		if(cpuScore == 3) {
			activatePinkLight.SetActive (true);
		}

		if(cpuScore == 4) {
			activateGreenLight.SetActive (true);
		}

		if(cpuScore >= 5){
			//gameState.gameOver;
			startBox.SetActive(true);
		}
	}

	// score keeping
	public int updatePlayerScore () {
		playerScore = playerScore + 100;
		updateScore ();
		return playerScore;
	}

	public int updateCpuScore () {
		cpuScore = cpuScore + 1;
		return cpuScore;
	}

	void updateScore() {
		updateScoreboard.updateScore();
	}

	public void startGame () {
		gameState = 1;
		startBox.SetActive (false);
		gameLevel.SetActive (true);
		startMusic.SetActive (true);
		startButton = GameObject.Find ("StartSwitch");
		startButton.transform.position = new Vector3(10, -5, -85);
		//Invoke("spawnEnemies", 4);
		Invoke("spawnTargets", 0);

	}

	// spawns enemies
	void spawnEnemies () {
		int numEnemies = 10;
		//var enemy = droid;
		float speed = 10f;

		source.PlayOneShot (activateSound, 0.7f);

		for (int i = 0; i < numEnemies; i++) {
			Rigidbody cloneEnemy = new Rigidbody ();
			cloneEnemy = (Rigidbody)Instantiate (enemy, transform.position, transform.rotation);
			cloneEnemy.GetComponent<Rigidbody> ().velocity = transform.TransformDirection (Vector3.forward * speed);
		}
	}

	// spawns targets
	void spawnTargets () {
		
		float speed = 1f;
		//var target = ball;

		source.PlayOneShot (activateSound, 0.7f);

		for (int i = 0; i < numTargets; i++) {
			//GameObject sphere = GameObject.CreatePrimitive (PrimitiveType.Sphere);
			//cloneTarget.AddComponent<Rigidbody> ();
			//cloneBall.transform.position = new Vector3(0, 0, 0);
			Debug.Log("start spawn");
			Rigidbody cloneTarget = new Rigidbody ();
			cloneTarget = (Rigidbody)Instantiate (cubeTarget, transform.position, transform.rotation);
			cloneTarget.GetComponent<Rigidbody> ().velocity = transform.TransformDirection (Vector3.up * speed);


		}
	}

	public void resetBall () {
		warpPlane.SetActive (false);
		source.PlayOneShot(activateSound, 0.7f);
		ball.GetComponent<Rigidbody> ().velocity = new Vector3 (0, 0, 0);
		ball.transform.position = new Vector3(0, 27, 15);
	}
}
