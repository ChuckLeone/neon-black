using UnityEngine;
using System.Collections;

public class scoreBoard : MonoBehaviour {
	[SerializeField] public GameObject score;
	public gameLoop gLoop;

	//public int score = gameLoop.playerScore;
	//public int score;
	// Use this for initialization
	void Start () {
		GetComponent<TextMesh>().text = "0";
	}
	
	// Update is called once per frame
	public void Update () {
	
	}

	public void updateScore() {
		//score = gLoop.playerScore;
		Debug.Log("update the scoreboard");
		Debug.Log("player score is: " + gLoop.playerScore.ToString());
		GetComponent<TextMesh>().text = (gLoop.playerScore.ToString());
	}
}
