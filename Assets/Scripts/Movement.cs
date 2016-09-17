using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{

	public float forca, kickPage, kickBook;
	bool canJump, canBounce;
	Rigidbody2D _rb;
	public Vector2 playerSpeed;

	void Start()
	{	
		canBounce = true;
		_rb = GetComponent<Rigidbody2D> ();

	}

	void Update ()
	{
		playerSpeed = _rb.velocity;
		Bounce ();
		if(Vector2.Distance (playerSpeed, new Vector2(0,0)) < 0.1){
			canBounce = true;
			print ("CAN BOUNCE");
		}else{
			//print ("CANT");
		}

	}

	void OnTriggerEnter2D (Collider2D coll)
	{
		if (canBounce) {
			if (coll.tag == "Page") {
				//print ("AloPAGE");
				gameObject.GetComponent<Rigidbody2D> ().velocity = (Vector3.up * kickPage * Time.deltaTime);
				canBounce = false;
				canJump = false;
			}else if(coll.tag == "Book"){
				gameObject.GetComponent<Rigidbody2D> ().velocity = (Vector3.up * kickBook * Time.deltaTime);
				canBounce = false;
				canJump = false;
			}
				
		}
		if(coll.tag == "Page" || coll.tag == "Book")
		{
			Destroy (coll.gameObject);
		}
	}
	void OnCollisionEnter2D(Collision2D coll)
	{
		//print ("AAAAAAAAAAS"); 
		canJump = false;
		canBounce = false;
	}

	void Bounce()
	{
		if (Input.GetKeyDown (KeyCode.Space)) {
			canJump = true;
			//	print ("AAAA");
			GetComponent<Rigidbody2D> ().velocity = (Vector3.down * forca * Time.deltaTime);
		}
	}
}