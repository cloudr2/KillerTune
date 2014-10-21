using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public static Player instance = null;
	public Vector3 initialPosition;
	public int HP;
	public bool isDead = false;

	void Awake()
	{
		if(instance == null && isDead == false){
			instance = this;
			HP = 3;
		}
	}


	void Update()
	{
		Debug.Log(HP);
		if(HP <= 0)
		{
			isDead = true;
			//if(Game.instance)
			GameManager.instance.ShowRestartButton ();
		}
	}

}
