using UnityEngine;
using System.Collections;

public class Paused : MonoBehaviour
{
	bool pause;
	public GameObject pauseManager;

	void Start ()
	{
		Time.timeScale = 1;
		pauseManager.gameObject.SetActive (false);
		pause = true;
	}

	void Update ()
	{
		if (pause) {
			if (Input.GetKeyUp (KeyCode.P)) {
				Time.timeScale = 0;
				pauseManager.gameObject.SetActive (true);
				pause = false;
			}
		} else if (pause == false) {
			if (Input.GetKeyUp (KeyCode.P)) {
				Time.timeScale = 1;
				pauseManager.gameObject.SetActive (false);
				pause = true;
			}
		}
	}
}
