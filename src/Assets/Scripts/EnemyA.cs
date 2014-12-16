using UnityEngine;
using System.Collections;

public class EnemyA : Enemy {

	void Awake()
	{
		this.lifeSpan = 3;
		this.heal = 1;
		this.damage = -3;
		this.scoreValue = 100;
	}

}