using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	protected float lifeSpan;
	//protected Vector3 initialPosition;
	
	public void initialize(float lifeSpan/*, Vector3 initialPosition*/)
	{
		this.lifeSpan = lifeSpan;
		//this.initialPosition = initialPosition;
	}
}
