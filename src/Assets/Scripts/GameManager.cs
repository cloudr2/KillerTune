using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;
	public Game gamePrefab;

	public Rect scoreRect;
	public Rect highScoreRect;

	public Color BGColorA;
	public Color BGColorB;

	public GUIButton restartButtonPrefab;

	public Camera camera;
	//public bool IsPlayable = false;

	private Game game;
	private static float currentSpawnRate;
	private static Track track;

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
		HealthManager.instance.ResetHealth ();
		StartCoroutine (FlickBackground ());
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
		GUI.Box(scoreRect,"SCORE: " + currentScore.ToString());
		GUI.Box(highScoreRect,"HIGHSCORE: " + ScoreManager.instance.highScore.ToString());
	}

	public IEnumerator FlickBackground()
	{
		while(Game.instance){
			if(camera.backgroundColor == BGColorA)
				camera.backgroundColor = BGColorB;
			else
				camera.backgroundColor = BGColorA;
			
			yield return new WaitForSeconds (GameManager.GetCurrentSpawnRate());
		}
	}
}
