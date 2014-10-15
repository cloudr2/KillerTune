using UnityEngine;
using System.Collections;

public class EnemyA : Enemy {

	protected float lifeSpan = 5;

	void Awake () {
		base.initialize (lifeSpan);
	}

