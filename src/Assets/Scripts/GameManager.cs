using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;
	public Game gamePrefab;


	public Rect scoreRect;
	public Rect highScoreRect;
	public Rect playerHPRect;

	public GUIButton restartButtonPrefab;

	//public bool IsPlayable = false;

	private Game game;
	private static float currentSpawnRate;
	private static Track track;

	private int currentHP;
	private int currentScore = 0;

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

	public void StartGame()
	{
		Debug.Log("==START==");
		track = (Track)AudioManager.instance.randomTrackId;
		currentSpawnRate = track.BMPtoSeconds();
		//reiniciar el label de currentScore = 0;
		game = (Game)Instantiate(gamePrefab);
		currentScore = 0;
	}

	public void ShowRestartButton(){
		Debug.Log("==END==");
		Destroy (game.gameObject);
		StopAllCoroutines ();
		ScoreManager.instance.SetHighScore(currentScore);
		ScoreManager.instance.GetHighScore ();
		GUIButton restartButton = (GUIButton)Instantiate(restartButtonPrefab);
		//restartButton.transform.parent = transform;
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
		if(Player.instance.isDead)
			currentHP = 0;
		else
			currentHP = Player.instance.HP;
		
		GUI.Label(playerHPRect,"HP LEFT: " + currentHP.ToString ());
		GUI.Label(scoreRect,"SCORE: " + currentScore.ToString());
		GUI.Label(highScoreRect,"HIGHSCORE: " + ScoreManager.instance.highScore.ToString());
	}
}
