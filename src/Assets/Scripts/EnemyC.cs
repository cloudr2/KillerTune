using UnityEngine;
using System.Collections;

public class EnemyC : Enemy {
	
	protected override int lifeSpan {get {return 3;}set{}}
	protected override int scoreValue {get{return 300;}}
	protected override int damage {get{return 1;}}//deals damage as a negative value (heals if positive)
	protected override int heal {get{return -3;}}//amount of hp recovered per kill (damages if negative)
	
}