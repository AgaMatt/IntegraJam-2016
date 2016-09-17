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
				_rb.velocity = new Vector2 (0, 0);
				//print ("AloPAGE");
				gameObject.GetComponent<Rigidbody2D> ().AddForce(Vector3.up * kickPage * Time.deltaTime);
				canBounce = false;
				canJump = false;
			}else if(coll.tag == "Book"){
				_rb.velocity = new Vector2 (0, 0);
				gameObject.GetComponent<Rigidbody2D> ().AddForce (Vector3.up * kickBook * Time.deltaTime);
				canBounce = false;
				canJump = true;
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
		canJump = true;
		canBounce = false;
	}

	void Bounce()
	{
			if (Input.GetKeyDown (KeyCode.Space)) {
			_rb.velocity = new Vector2 (0, 0);
				canJump = true;
				canBounce = true;
				//	print ("AAAA");
				GetComponent<Rigidbody2D> ().AddForce (Vector3.down * forca * Time.deltaTime);
			}
	}

}