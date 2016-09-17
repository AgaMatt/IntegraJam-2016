using UnityEngine;
using System.Collections;

public class Moviment : MonoBehaviour {

	public float forca, kickPage, kickBook;
	public GameObject player;

	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");

	
	}
	

	void Update () {
		
		if (Input.GetKeyDown (KeyCode.Space)) {
			print ("AAAA");
			GetComponent<Rigidbody2D> ().AddForce (Vector3.down * forca * Time.deltaTime);
		}
	}

	void OnCollisionEnter(Collider2D coll)
	{
		if(coll.tag == "Page")
		{
			print ("AloPAGE");
			gameObject.GetComponent<Rigidbody2D> ().AddForce (Vector3.up * kickPage * Time.deltaTime);
			Destroy (coll);
		}
	}
}
