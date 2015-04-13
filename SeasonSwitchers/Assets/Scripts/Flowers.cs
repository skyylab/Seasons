using UnityEngine;
using System.Collections;


public class Flowers : MonoBehaviour 
{
	public GameObject[] flowersList;

	void Update () 
	{
		
		if (EndingSwitch.seasonSpring == false)
		{
			foreach (GameObject go in flowersList)
			{
				go.GetComponent<SpriteRenderer>().enabled = false;
				go.GetComponent<BoxCollider2D>().enabled = false;
			}
		}
		else if (EndingSwitch.seasonSpring == true)
		{
			foreach (GameObject go in flowersList)
			{
				go.GetComponent<SpriteRenderer>().enabled = true;
				go.GetComponent<BoxCollider2D>().enabled = true;
			}
		}

		}
	}
