using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour 
{
	Transform playerTransform; 
	Quaternion targetLook;
	
	
	Vector3 targetMove; 
	Vector3 cameraVelocity;
	public float smoothMove = 0.5f;
	public float cameraSmooth = 0.5f; 
	public float cameraDistance = 5; 
	public float cameraHeight = 3; 
	public float smoothtime = .2f; 
	
	
	void Start () 
	{
		playerTransform = GameObject.FindWithTag("Player").transform;
	}
	
	void Update () 
	{
		targetMove = playerTransform.position + ( new Vector3 (0, cameraHeight,-cameraDistance));
		transform.position = Vector3.SmoothDamp (transform.position, targetMove, ref cameraVelocity, smoothtime);
	}
}
