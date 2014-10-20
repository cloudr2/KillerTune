using UnityEngine;
using System.Collections;

public static class TracksBPM{
	
	public static int trackCount = 1;

	public static float[] stageTrack = {
		30
		/*60,
		120,
		180,
		240,
		300,
		360*/
	};

	public static float BMPtoSeconds (this Track track)
	{
		return (stageTrack[(int)track])/60;
	}
}
