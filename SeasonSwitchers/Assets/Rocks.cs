using UnityEngine;
using System.Collections;

public class Rocks : MonoBehaviour 
{
	public GameObject[] rockList;
	
	void Update () 
	{
		
		if (EndingSwitch.seasonWinter == false)
		{
			foreach (GameObject go in rockList)
			{
				go.GetComponent<SpriteRenderer>().enabled = false;
				go.GetComponent<BoxCollider2D>().enabled = false;
			}
		}
		else if (EndingSwitch.seasonWinter == true)
		{
			foreach (GameObject go in rockList)
			{
				go.GetComponent<SpriteRenderer>().enabled = true;
				go.GetComponent<BoxCollider2D>().enabled = true;
			}
		}
		
	}
}
