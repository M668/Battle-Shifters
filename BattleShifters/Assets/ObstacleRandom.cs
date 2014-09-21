using UnityEngine;
using System.Collections;

public class ObstacleRandom : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Placements of others
		int xObs1 = Mathf.RoundToInt (GameObject.FindGameObjectWithTag ("Obstacle1").transform.position.x);
		int yObs1 = Mathf.RoundToInt (GameObject.FindGameObjectWithTag ("Obstacle1").transform.position.y);
		int xObs2 = Mathf.RoundToInt (GameObject.FindGameObjectWithTag ("Obstacle2").transform.position.x);
		int yObs2 = Mathf.RoundToInt (GameObject.FindGameObjectWithTag ("Obstacle2").transform.position.y);
		//Random position
		int xNum;
		int yNum;
		do {
		xNum = Random.Range(-5, 5);
		yNum = Random.Range(-5, 5);
		} while (
			((xObs1 == xNum) && (yObs1 == yNum))
			||
			((xObs2 == xNum) && (yObs2 == yNum))
			);
		transform.position = new Vector2(xNum, yNum);
		Debug.Log ("Finished Obstacle Placement");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}