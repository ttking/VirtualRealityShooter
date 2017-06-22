using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryGame : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Projectile") {
			SceneManager.LoadScene ("main");
			Debug.Log (";sldk;askd;sak");
		}
	}
}
