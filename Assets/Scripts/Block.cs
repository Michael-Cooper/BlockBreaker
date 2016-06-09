using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {
	
	private int timesHit = 0;
	public Sprite[] spriteArray;
//	public int sprite;
//	private int sprite;
//	public Sprite oneHit;
//	public Sprite twoHits;
//	public Sprite threeHits;
//	SpriteRenderer sr;
	public int maxHits;
	private LevelManager levelManger;
	
	// Use this for initialization
	void Start () 
	{
		levelManger = GameObject.FindObjectOfType<LevelManager>();
//		sprite = maxHits;
//		sr = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
	void OnCollisionEnter2D (Collision2D collision)
	{
		timesHit++;
//		sprite--;
		if (timesHit >= maxHits)
			GameObject.Destroy (gameObject);
		else
		{
			LoadSprites ();
		}
		
//		if (sprite == 3)
//			sr.sprite = threeHits;
//		if (sprite	== 2)
//			sr.sprite = twoHits;
//		if (sprite == 1)
//			sr.sprite = oneHit;
			
	}
	
	void LoadSprites ()
	{
		int spriteIndex = timesHit - 1;
		this.GetComponent<SpriteRenderer>().sprite = spriteArray[spriteIndex];
	}
	
	
	
}