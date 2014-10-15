using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {

	public Player playerPrefab;
	public EnemySpawner enemySpawnerPrefab;
	public SpawnArea spawnAreaPrefab;

	private Player player;
	private EnemySpawner enemySpawner;
	private SpawnArea spawnArea;

	void Awake () {
		Initialize();
	}

	void Start()
	{
		StartCoroutine(enemySpawner.GenerateEnemy());
	}

	void OnDestroy()
	{
		StopAllCoroutines();
	}

	private void Initialize()
	{
		player = (Player)Instantiate (playerPrefab);
		player.transform.parent = transform;
		player.initialPosition = new Vector3 (0,0,0);

		enemySpawner = (EnemySpawner)Instantiate (enemySpawnerPrefab);
		enemySpawner.transform.parent = transform;

		spawnArea = (SpawnArea)Instantiate (spawnAreaPrefab);
		spawnArea.transform.parent = transform;
	}
}
