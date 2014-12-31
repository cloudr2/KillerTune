using UnityEngine;
using System.Collections;

public class EnemyA : Enemy {

	protected override int lifeSpan {get {return 3;}set{}}
	protected override int scoreValue {get{return 100;}}
	protected override int damage {get{return -3;}}//deals damage as a negative value
	protected override int heal {get{return 1;}}//amount of hp recovered per kill

}