using UnityEngine;
using System.Collections;

public class EndingSwitch : MonoBehaviour 
{
	//seasons
	public static bool seasonSwitch; 
	public static bool seasonWinter;
	public static bool seasonSpring;

	//enum shit
	private float waitFor= 0.5f; 

	//scripts we gotta turn off and on
	checkStopMoving checkMovOn; 
	PlayerInput playerMovOn;
	public GameObject witch; 
	private float saveSpeed =0f;


	// Use this for initialization
	void Awake ()
	{
		seasonSpring = true;
		seasonWinter = false; 
		seasonSwitch = false; 
		checkMovOn = FindObjectOfType<checkStopMoving>();
		playerMovOn = FindObjectOfType<PlayerInput>();
	}
	void Start () 
	{
	
	}
	void Update () 
	{
	
	}
	void OnTriggerEnter2D (Collider2D coll)
	{
		seasonSwitch = true;
		witch.transform.eulerAngles = new Vector3(0, 180 ,0);
		checkMovOn.enabled = false;
		saveSpeed = playerMovOn.moveSpeed; 
		playerMovOn.enabled = false;
	
		if (seasonSwitch && seasonSpring)
		{
			seasonWinter = true; 
			seasonSpring = false;
			seasonSwitch = false; 
			Debug.Log ("It is Winter");
		}
//		else if (seasonSwitch && seasonWinter)
//		{
//			seasonSpring =true; 
//			seasonWinter = false; 
//			Debug.Log("It is Spring");
//		}

		else
		{
		Invoke("turnMoveOn", waitFor);
		}



	}
	void turnMoveOn()
	{
		playerMovOn.enabled = true;
		playerMovOn.moveSpeed = (saveSpeed *-1); 
		checkMovOn.enabled = true;
	}
}
