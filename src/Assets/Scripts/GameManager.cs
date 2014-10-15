using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;

	public Game gamePrefab;
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
