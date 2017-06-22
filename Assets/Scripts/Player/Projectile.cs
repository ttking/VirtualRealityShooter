using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Projectile : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Destroy (gameObject, 3f);
	}
	
	// Update is called once per frame
	void OnCollisionEnter(Collision other){
		if(other.gameObject.tag == "Enemy"){

			GameObject scoreObject = GameObject.FindGameObjectWithTag ("Score");
			Score pScore = scoreObject.GetComponent<Score> ();
			pScore.score += 10;

			Destroy (other.gameObject);
			Destroy (this.gameObject);

			// Decrease spawn time
		}
		if (other.gameObject.tag == "MainCamera"){
			SceneManager.LoadScene ("Suicide");
		}
			
	}
}
