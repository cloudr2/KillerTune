using UnityEngine;
using System.Collections;

public class ScoreManager:MonoBehaviour {

	public static ScoreManager instance = null;
	
	public int highScore = 0;

	string highScoreKey = "HighScore";


	void Awake()
	{
		if(instance == null){
			instance = this;
			GetHighScore ();
		}
	}

	public void GetHighScore()
	{
		highScore = PlayerPrefs.GetInt(highScoreKey,0);
	}
	public void SetHighScore(int score)
	{
		if(score > highScore){
			PlayerPrefs.SetInt (highScoreKey,score);
			PlayerPrefs.Save ();
		}
 	}


}
