using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* things to code(todo list)
control the ship
fire weapons
do damage
ship death
combat field/s
ship's internals
make a player
move player
player's use action
devoted stations (helm,weapon comp,etc..)
ship hazards
player death
user interface
non-combat field/s
star charts
unique locations
locations hazards
unique weapons
multiple ammo shot
unique passives
debuffs
buffs
Main menu scene
character/ship select scene
game over scene
multi-player ability
player to player interaction
(STILL not sorry~!)
*/
public class Base_Ship : MonoBehaviour {
	//combat
	int			health;		//damage before death
	int			sheild;		//rechargable health before health
	int			crypt;		//security levels
	//non-combat
	float		energy;		//power for the ship
	int			weaponCap;	//max amount of weapons
	string[]	weaponSlot;
	int			cargoCap;	//max amount of cargo space
	string[]	cargo;
	float		lifeSupport;
	int			thrust;
	int			mass;
	string[]	upgradeSS;
	int			warp;		//(0=tachyon/1=alcubierre/2=teleport)
	
	int Health(){
		return health;
	}
	void Health(int value){
		health = value;
	}
	
	int Sheild(){
		return sheild;
	}
	void Sheild(int value){
		sheild = value;
	}
	
	int Crypt(){
		return crypt;
	}
	void Crypt(int value){
		crypt = value;
	}
	
	void Hit (int dmgTake){
		if (sheild > dmgTake){
			sheild -= dmgTake;
		}
		if (sheild == 0){
			health -= dmgTake;
		}
		if (sheild <= dmgTake){
			sheild = 0;
			health = health -(dmgTake - sheild);
		}
		if (health <= 0){
			//Debug.unityLogger.Log(health, "ship dead!")
			//dead
		}
	}
	
	void Start () {
		
	}
	void Update () {
		
	}
}
