﻿using UnityEngine;
using System.Collections;

public class SpawnArea: MonoBehaviour {

	public Vector3 spawnRange {get{return new Vector3((Random.Range (-8f,8f)),(Random.Range (-4f,4f)),0);}}
}
