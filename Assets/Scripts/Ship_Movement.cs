using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship_Movement : MonoBehaviour {
/*
WASD in local
automatic inertial dampining
	rotational and linier
slow accel

deccel rate constint	
*/
	int topSpeed;
	int turnSpeed;
	int currentSpeed;
	int currentTurnS;
	int acceleration;
	
	
	void Start () {
		int thrust;
		int mass;
		acceleration = thrust / mass; //get componet that is need for this ship
		//get 
	}
	
	void Update () {
		
	}
}
