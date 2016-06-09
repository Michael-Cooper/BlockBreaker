using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour 
{
	private Paddle paddle;
	private Vector3 paddleToBallVector;
	private bool hasStarted = false;
	private int blockHits = 0;
	public LevelManager levelManager;

	// Use this for initialization
	void Start () 
	{
		paddle = GameObject.FindObjectOfType<Paddle>();
		paddleToBallVector = transform.position - paddle.transform.position;
		Debug.Log (paddleToBallVector.y);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		if (hasStarted == false)
		{
			transform.position = paddle.transform.position + paddleToBallVector;
		
			if (Input.GetMouseButtonDown (0))
			{
				Debug.Log ("mouse button clicked");
				this.GetComponent<Rigidbody2D>().velocity = new Vector2 (Random.Range (-5f, 5f),7f);
				hasStarted = true;
			}
		}
	}
	
	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.gameObject.tag == "block")
			blockHits ++;
		
		if (blockHits == 13)
			levelManager.LoadLevel ("Level_2");
	
		if (col.gameObject.tag == "paddle")
			this.GetComponent<Rigidbody2D>().velocity = new Vector2 (((transform.position.x - paddle.transform.position.x) * 15),7f);
	}
}
