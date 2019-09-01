using UnityEngine;
using System.Collections;

public class PlayMoving : MonoBehaviour {

	//look in "this" function. try to personalize and keep each script to hold different object values
	    //if not possible, just make separate scripts for each object


	//store all the individual player locations in this script in different arrays
		//then have external scripts (DoMove?) invoke a keyCode for indvSetofLocations

	//!!!!~~~ keep player properties/money in a separate script

	public PlayController monopolyGame;
	public float MoveSpeed;
	public float RotationSpeed;

	public GameObject[] boardSpace;	
	public bool is_Moving;
	
	Vector3 playPosition ; Vector3 playTarget ;
	public int currentSpaceNum;
	public int targetSpaceNum;
	public bool passedGO; //maynot need~~!!!

	private string name;
	public bool inJail;

	// Use this for initialization
	void Start () {
		inJail = false;
		is_Moving = false;
		currentSpaceNum = 0;
		targetSpaceNum = 0;
		passedGO = false;
	}
	
	// Update is called once per frame

	//first need to get diceRolling working


	void Update () {
		if (targetSpaceNum != currentSpaceNum) { is_Moving = true;	} //not sure if needed, temporary

		if (is_Moving) 
		{
			playPosition = this.gameObject.transform.localPosition;
			playTarget = boardSpace[targetSpaceNum].transform.localPosition;
			float dis = Vector3.Distance(playPosition,playTarget);
			
			if(dis<0.05f) {
				is_Moving = false;
				currentSpaceNum = targetSpaceNum;
			}
			this.gameObject.transform.localPosition = Vector3.MoveTowards(playPosition,playTarget,15.0f*Time.deltaTime);
		}
	}

	private bool jailSkipSequence(){
		if (currentSpaceNum == 40) {
			targetSpaceNum = 10;
			monopolyGame.advPlayerOrder();
			return true;
		}
		return false;
	}

	public void editName (string nm){
		name = nm;
		print ("player name has been changed to: " + name);
	}
	public string getName(){
		return name;
	}

	public void travelToNewLocation(int travelingDistance){ //takes an int for the dice value of to new square
		if (jailSkipSequence ()) {
			monopolyGame.consoleText = "sucks, in jail";
		} else {
			targetSpaceNum = travelingDistance + currentSpaceNum;
			if (targetSpaceNum >= 40) {
				targetSpaceNum = targetSpaceNum - 40;
				passedGO = true;
				//!!~~add $200 to player's wallet
			}
		}
	}
	public void forceNewLocation (int newLocation){ //teleport, no GO
		targetSpaceNum = newLocation;
		passedGO = false;
	}
	public void resetPassGo(){
		passedGO = false;
	}
	public bool hasPassedGo(){
		return passedGO;
	}
}
