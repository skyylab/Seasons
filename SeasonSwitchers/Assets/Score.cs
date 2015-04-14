using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	
	public static int currentScore = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<TextMesh> ().text = currentScore.ToString ();
	}
	
	void Awake() {
		DontDestroyOnLoad(transform.gameObject);
	}
	
}