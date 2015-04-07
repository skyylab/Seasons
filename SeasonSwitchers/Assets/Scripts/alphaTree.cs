using UnityEngine;
using System.Collections;

public class alphaTree : MonoBehaviour 
{
	public float alphaLevel;
	private SpriteRenderer sR;

	void Start () 
	{
		sR = GetComponent<SpriteRenderer>(); 
		sR.color = new Color (1f, 1f, 1f, alphaLevel);

	
	}
	

	void Update () 
	{
	
	}
}
