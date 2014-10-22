using UnityEngine;
using System.Collections;

public class HealthManager : MonoBehaviour {

	public static HealthManager instance = null;

	public int maxHealth = 10 ;
	public int currentHealth = 10;
	private float healthPercent {get{return (float)maxHealth/currentHealth;}}

	void Awake()
	{
		if(instance == null)
			instance = this;
	}
	
	void OnGUI ()
	{
		GUI.Box(new Rect(0,Screen.height - 125,Screen.width/2/healthPercent,25),"HP");
		GUI.Box (new Rect(0,Screen.height - 100,Screen.width/2/healthPercent,25),currentHealth+"/"+maxHealth);
	}

	public void ResetHealth ()
	{
		currentHealth = maxHealth;
	}

	public void SetHealth (int health)
	{
		currentHealth += health;
		Player.instance.health =  currentHealth;
	}
}
