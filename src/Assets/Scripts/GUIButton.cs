using UnityEngine;
using System.Collections;

public class GUIButton : MonoBehaviour {

	public Rect buttonRect;

	void OnGUI()
	{
		if (GUI.Button(buttonRect,"Restart")){
			GameManager.instance.StartGame ();
			Destroy (this.gameObject);
		}
	}

}
