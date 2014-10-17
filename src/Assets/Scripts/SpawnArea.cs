using UnityEngine;
using System.Collections;

public class SpawnArea: MonoBehaviour {

	public Vector3 spawnRange {get{return new Vector3((Random.Range (-7f,7f)),(Random.Range (-5.5f,5.5f)),0);}}
}
