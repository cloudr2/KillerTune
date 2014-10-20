using UnityEngine;
using System.Collections;

public class EnemyA : Enemy {
	public int lifeSpan = 3;

	void Start()
	{

	}

	private IEnumerator LifeCountDown()
	{
		this.lifeSpan --;
		Debug.Log(this.lifeSpan);
		Debug.Log(GameManager.instance.spawnRate);
		yield return new WaitForSeconds(GameManager.instance.spawnRate);
		
	}

	void OnDestroy()
	{
		StopAllCoroutines ();
	}
}