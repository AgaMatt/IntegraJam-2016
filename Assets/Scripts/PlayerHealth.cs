using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {

	int fails;
	void Start()
	{
		fails = 3;
	}

	void Update()
	{
		if(fails < 0){
			//GAME RESTART
			SceneManager.LoadScene ("GameIn");
		}
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		print ("To morrendo");
		if(coll.gameObject.tag == "Floor"){
			print ("Mas consegui");
			fails--;
		}
			
	}

}
