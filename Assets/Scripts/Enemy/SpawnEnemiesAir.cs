using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemiesAir : MonoBehaviour {

	public GameObject airbornEnemy;
	public Transform[] spawnPoints;
	public float spawnTime = 3f;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}
	
	void Spawn(){
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);
		Instantiate (airbornEnemy,spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
	}
}
