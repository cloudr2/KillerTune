using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

	public Enemy[] enemyPrefab;

	public bool canSpawn{get{return GameManager.instance.IsPlayable;}}

	public IEnumerator GenerateEnemy()
	{
		while(canSpawn){
		int randomEnemy = (int)Random.Range(0,1);
		Enemy newEnemy = (Enemy)Instantiate(enemyPrefab[randomEnemy]);
		newEnemy.name = "Spawned_" + enemyPrefab[randomEnemy].name;
		yield return new WaitForSeconds(1);
		}
	}
}
