using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float forca, kickPage, kickBook;
	public GameObject player;
	bool canEat;

	void Start () {
	//	player = GameObject.FindGameObjectWithTag ("Player");

	
	}
	

	void Update () {
		
		if (Input.GetKeyDown (KeyCode.Space)) {
			canEat = true;
		//	print ("AAAA");
			GetComponent<Rigidbody2D> ().AddForce (Vector3.down * forca * Time.deltaTime);
		}
	}

	void OnTriggerEnter2D(Collider2D coll)
	{
		 print ("Colili");
		if (canEat) {
			if (coll.tag == "Page") {
				print ("AloPAGE");
				gameObject.GetComponent<Rigidbody2D> ().AddForce (Vector3.up * kickPage * Time.deltaTime);
				Destroy (coll.gameObject);
				canEat = false;
			}
		}
	}
}