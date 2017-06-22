using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMissileEnemies : MonoBehaviour {

	public GameObject Enemy;
	public Transform[] spawnPoints;
	public float spawnTime = 3f;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}

	void Spawn(){
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);
		Instantiate (Enemy,spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
	}
}
