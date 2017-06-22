using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTowardsPlayer : MonoBehaviour {

	private GameObject player;
	public float speed;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 targetDir = player.transform.position - transform.position;
		float step = speed * Time.deltaTime;
		Vector3 newDir = Vector3.RotateTowards (transform.forward, targetDir, step, 0.0f);
		Debug.DrawRay (transform.position,newDir, Color.red);
		transform.rotation = Quaternion.LookRotation (newDir);
	}
}
