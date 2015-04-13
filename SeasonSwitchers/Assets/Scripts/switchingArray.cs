using UnityEngine;
using System.Collections;

public class switchingArray : MonoBehaviour 
{
	public Sprite[] sprites;
	SpriteRenderer sR; 
	private int currentIndex =0; 
	// Use this for initialization
	void Start () 
	{
	sR = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (EndingSwitch.seasonWinter && (currentIndex == 0))
		{
			currentIndex += 1;
			sR.sprite = sprites[currentIndex];

		}
		if (EndingSwitch.seasonSpring && (currentIndex == 1))
		{
			currentIndex -= 1;
			sR.sprite = sprites[currentIndex];
			
		}
	
	}
}
