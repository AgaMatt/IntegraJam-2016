using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{

	public float forca, kickPage, kickBook, kickFloor;
	public GameObject player;
	bool canJump;


	void Update ()
	{
		
		if (Input.GetKeyDown (KeyCode.Space)) {
			canJump = true;
			//	print ("AAAA");
			GetComponent<Rigidbody2D> ().AddForce (Vector3.down * forca * Time.deltaTime);
		}
	}

	void OnTriggerEnter2D (Collider2D coll)
	{
		//print ("Colili");
		if(coll.tag == "Floor"){
			canJump = false;
		}
		if (canJump) {
			if (coll.tag == "Page") {
				//print ("AloPAGE");
				gameObject.GetComponent<Rigidbody2D> ().AddForce (Vector3.up * kickPage * Time.deltaTime);
				canJump = false;
			}else if(coll.tag == "Book"){
				gameObject.GetComponent<Rigidbody2D> ().AddForce (Vector3.up * kickBook * Time.deltaTime);
				canJump = false;
			}
				
		}
		if(coll.tag == "Page" || coll.tag == "Book")
		{
			Destroy (coll.gameObject);
		}
	}
}