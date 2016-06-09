using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel (string name)
	{
		Debug.Log ("trying to load level: " + name);
		Application.LoadLevel(name);
	}
	
	public void QuitRequest ()
	{
		Debug.Log ("trying to quit");
		Application.Quit ();
	}
	
	public void LoadNextLevel ()
	{
		Application.LoadLevel(Application.loadedLevel + 1);
	}
}
