using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	static MusicPlayer instance = null;
	
	void Awake ()
	{
		if (instance != null)
		{
			GameObject.Destroy(gameObject);
		}
	}
	
	// Use this for initialization
	void Start () 
	{
		instance = this;
		GameObject.DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	
	
}
