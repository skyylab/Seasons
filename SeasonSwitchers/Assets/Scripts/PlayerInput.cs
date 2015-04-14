using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour 
{
	public float moveSpeed = 70f;
	public float jumpHeight = 9f; 

	private Rigidbody2D rb;
	private bool grounded; 
	private bool doubleJumped; 
	public int flip = 0;

	public Vector2 pPosition;

//	public static bool seasonSwitch; 
//	public static bool seasonWinter;
//	public static bool seasonSpring;

	void Start () 
	{
		pPosition = new Vector2 (0, 0);
		rb = GetComponent<Rigidbody2D>(); 
		rb.fixedAngle = true; 

	}


	void Update () 
	{
		rb.velocity = new Vector2(moveSpeed, rb.velocity.y);

		if (Input.GetKeyDown (KeyCode.Space) && grounded)
		{
			Jump ();
			doubleJumped = false; 

		}
		if (Input.GetKeyDown (KeyCode.Space) && !grounded && !doubleJumped)
		{
			Jump ();
			doubleJumped = true; 
		}

	}
	void Jump()
	{
		rb.velocity = new Vector2(rb.velocity.x, jumpHeight * 25);
	}

	void OnTriggerStay2D ( Collider2D col) {
		if (col.tag == "Ground") {
			grounded = true;
		}
	
	}
	 void OnTriggerExit2D ( Collider2D col) 
	{
		grounded = false;
	}


	void OnTriggerEnter2D ( Collider2D col)
	{
		if (col.tag == "Enemy" || col.tag == "DeathGround") 
		{
			gameObject.transform.position = pPosition;
			Score.currentScore += 1;
			EndingSwitch.seasonSpring = true;
			EndingSwitch.seasonWinter = false;

			if (checkStopMoving.goingLeft)
			{
				moveSpeed *= -1;
				gameObject.transform.eulerAngles = new Vector3(0, 360 ,0);
			}

		}
	}
	void OnCollisionEnter2D ( Collision2D col) {
		if (col.gameObject.tag == "Switch") {
			moveSpeed *= -1f; 
		}
	}
}
