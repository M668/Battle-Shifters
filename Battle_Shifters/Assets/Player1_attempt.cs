using UnityEngine;
using System.Collections;

bool ifValidMove() {
	return true;
}

public class Player1_attempt : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update() {
		//User Input
		if (Input.GetKeyDown ("w")){ 
			if (ifValidMove()) {
				transform.Translate(0,1,0);
				Debug.Log ("'w' has been detected");
			}
		}
		else if (Input.GetKeyDown("a")){
			if (ifValidMove()) {
				transform.Translate(-1,0,0);
				Debug.Log("'a' has been detected");
			}
		}
		else if (Input.GetKeyDown("s")){
			if (ifValidMove()) {
				transform.Translate(0,-1,0);
				Debug.Log("'s' has been detected");
			}
		}
		else if (Input.GetKeyDown("d")){
			if (ifVaildMove()) {
				transform.Translate(1,0,0);
				Debug.Log("'d' has been detected");
			}
		}
		else {
		}
		//Object Movement
		
	}
}