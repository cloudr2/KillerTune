using UnityEngine;
using System.Collections;

public class EnemyB : Enemy {

	
	void Awake()
	{
		this.lifeSpan = 5;
		this.heal = 2;
		this.damage = -5;
		this.scoreValue = 500;
	}


}
