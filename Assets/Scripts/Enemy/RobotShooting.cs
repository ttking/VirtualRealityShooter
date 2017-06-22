using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotShooting : MonoBehaviour {

	public Transform[] muzzles;

	public GameObject missile;

	private float spawnTime = 3f;
	private float repeatTime = 5f;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("SpawnMissile", spawnTime, repeatTime);
	}
	
	// Update is called once per frame
	void SpawnMissile () {
		int spawnPointIndex = Random.Range (0, muzzles.Length);
		Instantiate (missile,muzzles[spawnPointIndex].position, muzzles[spawnPointIndex].rotation);
	}
}
