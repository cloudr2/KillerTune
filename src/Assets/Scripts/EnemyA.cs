using UnityEngine;
using System.Collections;

public class EnemyA : Enemy {
	public float lifeSpan = 3f;

	void Start()
	{

	}

	private IEnumerator LifeCountDown()
	{
		for (int i = 0; i < ; i++) {
			
				}
		
	}

	void OnDestroy()
	{
		StopAllCoroutines ();
	}
}