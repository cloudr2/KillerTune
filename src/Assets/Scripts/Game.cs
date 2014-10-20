using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {

	public static Game instance = null;

	public Player playerPrefab;
	public EnemySpawner enemySpawnerPrefab;
	public GUIButton restartButtonPrefab;

	private Player player;
	private EnemySpawner enemySpawner;
	private GUIButton restartButton;

	void Awake () {
		if(instance == null){
			instance = this;
		}
	}

	void Start()
	{
		Initialize();
		StartCoroutine(enemySpawner.GenerateEnemy());
	}

	private void Initialize()
	{
		player = (Player)Instantiate (playerPrefab);
		player.transform.parent = transform;
		player.initialPosition = new Vector3(0,0,0);

		enemySpawner = (EnemySpawner)Instantiate (enemySpawnerPrefab);
		enemySpawner.transform.parent = transform;
	}

	public void EndGame(){
		if(enemySpawner != null)
		Destroy(enemySpawner.gameObject);

		if(player != null)
			Destroy(player.gameObject);

		Debug.LogWarning(instance);
		StopAllCoroutines ();
		restartButton = (GUIButton)Instantiate(restartButtonPrefab);
		restartButton.transform.parent = transform;
	}
}
