using UnityEngine;
using System.Collections;

public class checkStopMoving : MonoBehaviour 
{
	private Rigidbody2D rb;
	Vector2 pPosition;
	public float currentPos;
	public float lastPos;

	PlayerInput playerMovOn;
	public static bool goingRight = true;
	public static bool goingLeft = false; 
	
	
	void Start () 
	{
		playerMovOn = FindObjectOfType<PlayerInput>();
		pPosition = new Vector2 (0f, 0f);
	}    
	void Update() 
	{
		
		currentPos = transform.position.x;
		//print (currentPos + "current");
		//print (lastPos + "last");
		if (currentPos == lastPos)
		{
			print("is not moving");
			gameObject.transform.position = pPosition;
			Score.currentScore += 1;
			playerMovOn.moveSpeed = 75f;
			EndingSwitch.seasonSpring = true;
			EndingSwitch.seasonWinter = false;
			if (goingLeft)
			{
				playerMovOn.moveSpeed *= -1;
				transform.eulerAngles = new Vector3(0, 360 ,0); 
			}

		}
		Invoke ("set",.9f);
		if (currentPos > lastPos )
		{
			goingRight = true;
			goingLeft = false; 
		}
		else
		{
			goingLeft = true;
			goingRight = false;
		}

	}
	
	void set()
	{
		lastPos = currentPos;
	}
	
	
}