using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;
	public Game gamePrefab;

	public Rect scoreRect;
	public Rect playerHPRect;
	//public bool IsPlayable = false;

	private Game game;
	private static float currentSpawnRate;
	private static Track track;
	private string playerLives;
	private int currentScore;

	void Awake()
	{
		if(instance == null)
		{
			instance = this;
		}
	}

	void Start () {

		StartGame();
	}

	private void StartGame()
	{
		Debug.Log("==START==");
		track = (Track)AudioManager.instance.randomTrackId;
		currentSpawnRate = track.BMPtoSeconds();
		currentScore = 0;
		game = (Game)Instantiate(gamePrefab);
	}

	public void RestartGame()
	{
		Debug.Log("==END==");
		Destroy (game.gameObject);
		StartGame();
	}

	public static float GetCurrentSpawnRate ()
	{
		return currentSpawnRate;
	}

	public void SetScore(int score)
	{
		currentScore += score;
	}

	void OnGUI()
	{
		GUI.Label(scoreRect,"SCORE: " + currentScore.ToString());
		GUI.Label(playerHPRect,"HP LEFT: " + Player.instance.HP.ToString ());
	}
}
