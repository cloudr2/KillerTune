using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

	public static AudioManager instance;
	public int randomTrackId{get{return Random.Range(0,TracksBPM.trackCount);}}

	void Awake()
	{
		if(instance == null)
			instance = this;
	}

	void Start()
	{
		//put the logic to play the track here using the random generated track id
	//	Debug.Log("Current track is: " + 'el_track');
	}
}
