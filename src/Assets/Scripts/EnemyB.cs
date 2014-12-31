using UnityEngine;
using System.Collections;

public class EnemyB : Enemy {
	
	protected override int lifeSpan {get {return 5;}set{}}
	protected override int scoreValue {get{return 500;}}
	protected override int damage {get{return -5;}}//deals damage as a negative value
	protected override int heal {get{return 2;}}//amount of hp recovered per kill

}
