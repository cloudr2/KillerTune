using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

	public Enemy[] enemyPrefab;
	public GameObject enemyContainer;
	public SpawnArea spawnarea;
	//public bool canSpawn{get{return GameManager.instance.IsPlayable;}}

	public IEnumerator GenerateEnemy()
	{
		Debug.Log("Track: " + GameManager.instance.track);
		Debug.Log("Spawn Rate in seconds: " + GameManager.instance.spawnRate);


		while(true){
			int randomEnemy = Random.Range(0,2);
			Enemy newEnemy = (Enemy)Instantiate(enemyPrefab[randomEnemy]);
			newEnemy.name = "Spawned_" + enemyPrefab[randomEnemy].name;
			newEnemy.transform.parent = enemyContainer.transform;
			newEnemy.transform.localPosition = spawnarea.spawnRange;
			Debug.Log(newEnemy.name + " has spawned!");
			yield return new WaitForSeconds(GameManager.instance.spawnRate);
			Debug.Log(GameManager.instance.spawnRate);
		}
	}
}
