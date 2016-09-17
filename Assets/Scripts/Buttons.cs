using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
	public void Play ()
	{
		SceneManager.LoadScene ("GameIn");
	}

	public void Options ()
	{
		SceneManager.LoadScene ("Options");
	}

	public void Credits ()
	{
		SceneManager.LoadScene ("Credits");
	}

	public void Store ()
	{
		SceneManager.LoadScene ("Store");
	}

	public void ReturnToMenu ()
	{
		SceneManager.LoadScene ("Menu");
	}

	public void Restart ()
	{ 
		SceneManager.LoadScene ("GameIn");
	}

	public void Quit ()
	{
		Application.Quit ();
	}
}
