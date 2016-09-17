using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	public Text scoreText;
	public int score;


	void OnTriggerEnter2D (Collider2D coll)
	{
		
		if (coll.tag == "Book") {
			score++;
			scoreText.text = score.ToString ();
		}
	}
}
