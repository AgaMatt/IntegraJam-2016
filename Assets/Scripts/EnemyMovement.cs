using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {
	
	public float acceleration, topSpeed;
	Rigidbody2D _rb;


	void Start () {
		_rb = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
		_rb.velocity = Vector2.left * acceleration * Time.deltaTime;
		var novaVelocidade = _rb.velocity;
		novaVelocidade = Vector3.ClampMagnitude (novaVelocidade, topSpeed);
		_rb.velocity = novaVelocidade;

	}
}
