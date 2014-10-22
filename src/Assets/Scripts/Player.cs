using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public static Player instance = null;
	public bool isDead = false;
	public Vector3 initialPosition;
	public int health;

	void Awake()
	{
		if(instance == null && isDead == false){
			instance = this;
			health  = HealthManager.instance.maxHealth;
		}
	}
	
	void Update()
	{
		if(health <= 0)
		{
			isDead = true;
			//if(Game.instance)
			GameManager.instance.ShowRestartButton ();
		}
	}

}
