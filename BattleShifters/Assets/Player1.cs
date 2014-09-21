using UnityEngine;
using System.Collections;

public class Player1 : MonoBehaviour {

	void Start () {
		//transform.position = new Vector2(0, -3);
		//Placements of others
		int xObs1 = Mathf.RoundToInt (GameObject.FindGameObjectWithTag ("Obstacle1").transform.position.x);
		int yObs1 = Mathf.RoundToInt (GameObject.FindGameObjectWithTag ("Obstacle1").transform.position.y);
		int xObs2 = Mathf.RoundToInt (GameObject.FindGameObjectWithTag ("Obstacle2").transform.position.x);
		int yObs2 = Mathf.RoundToInt (GameObject.FindGameObjectWithTag ("Obstacle2").transform.position.y);
		int xObsR = Mathf.RoundToInt (GameObject.FindGameObjectWithTag ("ObstacleRandom").transform.position.x);
		int yObsR = Mathf.RoundToInt (GameObject.FindGameObjectWithTag ("ObstacleRandom").transform.position.y);
		int xObsE = Mathf.RoundToInt (GameObject.FindGameObjectWithTag ("ObstacleRandom").transform.position.x);
		int yObsE = Mathf.RoundToInt (GameObject.FindGameObjectWithTag ("ObstacleRandom").transform.position.y);
		//Random position
		int xNum = 0;
		int yNum = 0;
		float distanceToPlayer = 0;
		do {
			xNum = Random.Range(-5, 5);
			yNum = Random.Range(-5, 5);
			transform.position = new Vector2(xNum, yNum);
			distanceToPlayer = Vector3.Distance (GameObject.FindGameObjectWithTag ("Enemy").transform.position,
			                              GameObject.FindGameObjectWithTag ("Player").transform.position);
		} while (
			((xObs1 == xNum) && (yObs1 == yNum))
			||
			((xObs2 == xNum) && (yObs2 == yNum))
			||
			((xObsR == xNum) && (yObsR == yNum))
			||
			((xObsE == xNum) && (yObsE == yNum))
			||
			distanceToPlayer < 5.0
			);
		Debug.Log ("Finished Player Placement");
	}

	// Update is called once per frame
	void Update() {
		// Gets/sets the X position of the player
		int X_pos = (int) transform.position.x;
		//Debug.Log(X_pos);
		// Gets/sets the Y position of the player
		int Y_pos = (int) transform.position.y;
		//Debug.Log(Y_pos);

		//User Input
		if (Input.GetKeyDown ("w")){
			if (Y_pos < 4) {
				transform.Translate(0,1,0);
				Debug.Log ("'w' has been detected");
			}
		}
		else if (Input.GetKeyDown("a")){
			if (X_pos > -5) {
				transform.Translate(-1,0,0);
				Debug.Log("'a' has been detected");
			}
		}
		else if (Input.GetKeyDown("s")){
			if (Y_pos > -5) {
				transform.Translate(0,-1,0);
				Debug.Log("'s' has been detected");
			}
		}
		else if (Input.GetKeyDown("d")){
			if (X_pos < 4) {
				transform.Translate(1,0,0);
				Debug.Log("'d' has been detected");
			}
		}
		else {
		}
	}

}