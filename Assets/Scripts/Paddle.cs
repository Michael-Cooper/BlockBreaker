using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour 
{
	float xMousePosition;
	
	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		xMousePosition =Mathf.Clamp((Input.mousePosition.x / Screen.width * 21.7f),.83f,18.4f);
		Vector3 paddlePosition = new Vector3 (0f,transform.position.y,0f);
		
		paddlePosition.x = xMousePosition;
		transform.position = paddlePosition;
	}
}
