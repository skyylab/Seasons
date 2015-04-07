using UnityEngine;
using System.Collections;

public class checkStopMoving : MonoBehaviour 
{
	private Rigidbody2D rb;
	Vector2 pPosition;
	float currentPos;
	float lastPos;
	
	
	void Start () 
	{
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
		}
		Invoke ("set",.9f);
		if (currentPos > lastPos )
		{
			transform.eulerAngles = new Vector3(0, 360 ,0); 
		}
		else
		{
			transform.eulerAngles = new Vector3(0,180 ,0); 
		}

	}
	
	void set()
	{
		lastPos = currentPos;
	}
	
	
}