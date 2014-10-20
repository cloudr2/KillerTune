using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public static Player instance = null;
	public Vector3 initialPosition;
	public int HP = 3;

	void Awake()
	{
		if(instance == null){
			instance = this;
			this.HP = 3;
		}
	}


	void Update()
	{
		Debug.Log(this.HP);
		if(this.HP < 0)
		{
			if(Game.instance)
			Game.instance.EndGame();
		}
	}

}
