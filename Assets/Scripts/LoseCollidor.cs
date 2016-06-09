using UnityEngine;
using System.Collections;

public class LoseCollidor : MonoBehaviour 
{
	private LevelManager levelManager;

	// Use this for initialization
	void Start () 
	{
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter2D (Collider2D collider)
	{
		Debug.Log ("trigger collider");
		levelManager.LoadLevel ("lose");
		
	}
	
	void OnCollisionEnter2D (Collision2D collision)
	{
		Debug.Log ("collision");
	}
}
