using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;

	public Game gamePrefab;
	//public bool IsPlayable = false;
	public Track track {get { return AudioManager.instance.randomTrackId;}}
	public float spawnRate {get {return track.BMPtoSeconds ();}}

	private Game game;

	void Awake()
	{
		if(instance == null)
			instance = this;
	}

	void Start () {
		StartGame();
	}
	
	void Update () {
	if(Input.GetKeyDown (KeyCode.Space))
		{
			RestartGame();
		}
	}

	private void StartGame()
	{
		Debug.Log("==START==");
		game = (Game)Instantiate(gamePrefab);
	}

	private void RestartGame()
	{
		Debug.Log("==END==");
		Destroy (game.gameObject);
		StartGame();
	}
}
