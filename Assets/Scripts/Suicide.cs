    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Suicide : MonoBehaviour {

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.name == "Projectile")
			SceneManager.LoadScene("Suicide");

	}
}