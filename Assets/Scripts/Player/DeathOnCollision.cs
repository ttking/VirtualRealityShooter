using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathOnCollision : MonoBehaviour {	

	void start(){
	}
	
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Base") 
		{
			SceneManager.LoadScene ("GameOver");
		}
	}
}