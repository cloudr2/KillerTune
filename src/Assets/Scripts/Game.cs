using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {

	public Player playerPrefab;
	public EnemySpawner enemySpawnerPrefab;
	private Player player;
	private EnemySpawner enemySpawner;

	void Awake () {
		Initialize();
	}

	void Start()
	{
		//GameManager.instance.IsPlayable = true;
		StartCoroutine(enemySpawner.GenerateEnemy());
		//Debug.Log("On Start: " + GameManager.instance.IsPlayable);
	}

	void OnDestroy()
	{
		StopAllCoroutines();
		//GameManager.instance.IsPlayable = false;
		//Debug.Log("On destroy: " + GameManager.instance.IsPlayable);
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
