using UnityEngine;
using System.Collections;

public class WaterCollider : MonoBehaviour {

	public GameObject[] waterList; 
	
	void Update () 
	{
		if (EndingSwitch.seasonSpring == true)
		{
			foreach (GameObject go in waterList)
			{

				go.GetComponent<BoxCollider2D>().enabled = true;
				go.tag = "DeathGround";
			}
		}
		else if (EndingSwitch.seasonWinter == true)
		{
			foreach (GameObject go in waterList)
			{
				go.GetComponent<BoxCollider2D>().enabled = false;
				go.tag = "Ground";
			}
		}
		
	}
}
