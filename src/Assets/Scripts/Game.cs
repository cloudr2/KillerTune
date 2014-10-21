using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {

	public static Game instance = null;

	public Player playerPrefab;
	public EnemySpawner enemySpawnerPrefab;

	private Player player;
	private EnemySpawner enemySpawner;

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
	
}
