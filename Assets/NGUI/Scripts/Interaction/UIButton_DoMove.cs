//----------------------------------------------
//            NGUI: Next-Gen UI kit
// Copyright © 2011-2013 Tasharen Entertainment
//----------------------------------------------

using UnityEngine;
using System.Collections;

/// <summary>
/// Similar to UIButtonColor, but adds a 'disabled' state based on whether the collider is enabled or not.
/// </summary>

[AddComponentMenu("NGUI/Interaction/Button")]
public class UIButton_DoMove : UIButtonColor
{
/*	public PlayMoving Shoe;
	public PlayMoving TopHat;
	public PlayMoving Thimble;
	public PlayMoving Battleship;
*/


	public PlayController monopolyGame;

	private PlayMoving currPlayer; //currently player for the move
	private PlayMoving tarPlayer; //target player for interaction with currPlayer

	public int diceValue1;
	public int diceValue2;

	/// <summary>
	/// Color that will be applied when the button is disabled.
	/// </summary>

	public Color disabledColor = Color.grey;

	/// <summary>
	/// If the collider is disabled, assume the disabled color.
	/// </summary>
	void start(){
		diceValue1 = 0;
		diceValue2 = 0;
	}
	protected override void OnEnable ()
	{
		if (isEnabled) base.OnEnable();
		else UpdateColor(false, true);
	}

	public override void OnHover (bool isOver) { if (isEnabled) base.OnHover(isOver); }
	public override void OnPress (bool isPressed) { 
		if (isEnabled) base.OnPress(isPressed); 
//		Shoe.is_Moving = true;
		if (Input.GetMouseButtonUp(0)){
			currPlayer = monopolyGame.GetCurrPlayer();
			playerMove(currPlayer);  //execute currentPlayer's move
			monopolyGame.advPlayerOrder();
		}
	}

	
	//methods below are used to excute the Movement of a single Player.
	
	public void playerMove(PlayMoving myPlayer){
		//make player roll dice
		var newDistance = stepsToTake ();
		    //generate random number, but also correspond to dice animation


		myPlayer.travelToNewLocation (newDistance);//have player move to newlocation
				//^(imbeded within PlayMoving.cs)^check to see to see if player passed GO

		if (isGoingToJail ()) {//check to see if player is going to jail (various ways)
			print ("player is going to jail");
			myPlayer.forceNewLocation(40);
		}
		//monopolyGame.consoleText = "did not pass go";
		if (myPlayer.hasPassedGo ()) {
			//monopolyGame.consoleText = "has just passed GO! adding money...";
			monopolyGame.getWallet(myPlayer).getWalletAmount();
			monopolyGame.getWallet(myPlayer).addMoney(200);
			myPlayer.resetPassGo();
			print ("money added. wallet: "+monopolyGame.getWallet(myPlayer).getWalletAmount());

		}

		var currentLand = (ArrayList) monopolyGame.LocationLibrary.getLand (myPlayer.currentSpaceNum);
		monopolyGame.consoleText = myPlayer.getName () + " traveling to : " + ((ArrayList)monopolyGame.LocationLibrary.getLand (myPlayer.targetSpaceNum))[0];
		if(monopolyGame.LocationLibrary.isSpecialLand(currentLand)){
		//	monopolyGame.consoleText =  "special land...";
			monopolyGame.LocationLibrary.specialLandProcess(myPlayer,monopolyGame.getWallet(myPlayer),monopolyGame.LocationLibrary.getLand(myPlayer.currentSpaceNum));
		}
		else if (hasBeenBought(currentLand)){//check to see if spot has been bought
			var rentAmount = (int)monopolyGame.LocationLibrary.calculateRent(currentLand);
			//var landOwner = (PlayerWallet)monopolyGame.LocationLibrary.getOwner(currentLand);
			//var myPwallet = monopolyGame.getWallet(myPlayer);
			if (!(Object.Equals (monopolyGame.getWallet(myPlayer),monopolyGame.LocationLibrary.getOwner(currentLand)))){

				//rent paying still needs to be validated

				print ("this amount being paid: "+rentAmount);
				monopolyGame.getWallet(myPlayer).subtractMoney(rentAmount);
				//myPwallet.subtractMoney(rentAmount);		//if bough, pay rent
				monopolyGame.LocationLibrary.getOwner(currentLand).addMoney(rentAmount);
				monopolyGame.consoleText = "rent paid";
			}
			else if(ReferenceEquals((PlayerWallet)monopolyGame.LocationLibrary.getOwner(currentLand), monopolyGame.getWallet(myPlayer))){//checks to see if Owned land and builds house
				print ("attempting building house");
				//<<insert buildHouse function
				if (monopolyGame.LocationLibrary.buildHouse((ArrayList) monopolyGame.LocationLibrary.getLand(myPlayer.currentSpaceNum))){
					monopolyGame.getWallet(myPlayer).subtractMoney((int)currentLand[2]);
				}
			}
		}
		else{
			buyLand_AI(myPlayer); //checks to see if theres enough money, buys if possible
		}
	}

	//private method to check and see if land has been bought
	private bool hasBeenBought(ArrayList myL){
		if ((myL[(myL.Count-1)].GetType() is PlayMoving)||(myL[(myL.Count-2)].GetType() is PlayMoving)) {
			return true;
		}
		return false;
	}

	//private method to decide whether or not to buy the land
	private void buyLand_AI(PlayMoving newOwner){ ///@@#$!@$#!@$ Battleship is buying with TophatMoney 
		//monopolyGame.consoleText = "new buyer is: "+ newOwner.getName ();
		if (monopolyGame.getWallet (newOwner).getWalletAmount () >= (int)(monopolyGame.LocationLibrary.getLand (newOwner.currentSpaceNum) [2])) {
		//	monopolyGame.consoleText =  newOwner.getName()+" buying "+(string)monopolyGame.LocationLibrary.getLand(newOwner.currentSpaceNum)[0];
			monopolyGame.LocationLibrary.getLand (newOwner.currentSpaceNum).Add (monopolyGame.getWallet (newOwner));
				//^^needs to be validated

			//print (currPlayer.getName() + " is buying site for:" + monopolyGame.LocationLibrary.getLand (newOwner.currentSpaceNum) [2]);
			//monopolyGame.getWallet (newOwner).getWalletAmount ();
			monopolyGame.getWallet (newOwner).subtractMoney ((int)monopolyGame.LocationLibrary.getLand (newOwner.currentSpaceNum) [2]);
			//>>____<<
			monopolyGame.getWallet(newOwner).addLand(monopolyGame.LocationLibrary.getLand(newOwner.currentSpaceNum));
				//^^^^this line needs validation still
			print ("site bought! Player now has: " + monopolyGame.getWallet (newOwner).getWalletAmount ());
		} else {
			monopolyGame.consoleText = "land not bought, insufficient funds";
		}
	}

	private int rollDice(){ //rolls a single 6sided dice and returns its value
		var number = Random.Range (1, 7);
		print (number);
		return number;
	}

	private int stepsToTake(){ //returns a int to be process in specific PlayerMoving, to calculate new location
		diceValue1 = rollDice ();
		diceValue2 = rollDice ();
		print (diceValue1);
		print (diceValue2);
		return diceValue1 + diceValue2;
	}	
	
	private bool isGoingToJail(){
		//check if the player's current position is at jail
		print (currPlayer.getName() + " checking...");
		if (currPlayer.currentSpaceNum == 30) {
			print ("player has landed on GoToJail");
			//>>><<change currPlayer JailStatus here.
			return true; //if so, edit jail status and jail counts return true
		} else {
			print ("nope, player is safe!");
			return false;
		}
	}
	
	




	/// <summary>
	/// Whether the button should be enabled.
	/// </summary>
	public bool isEnabled
	{
		get
		{
			Collider col = collider;
			return col && col.enabled;
		}
		set
		{
			Collider col = collider;
			if (!col) return;

			if (col.enabled != value)
			{
				col.enabled = value;
				UpdateColor(value, false);
			}
		}
	}

	/// <summary>
	/// Update the button's color to either enabled or disabled state.
	/// </summary>

	public void UpdateColor (bool shouldBeEnabled, bool immediate)
	{
		if (tweenTarget)
		{
			if (!mStarted)
			{
				mStarted = true;
				Init();
			}

			Color c = shouldBeEnabled ? defaultColor : disabledColor;
			TweenColor tc = TweenColor.Begin(tweenTarget, 0.15f, c);

			if (immediate)
			{
				tc.color = c;
				tc.enabled = false;
			}
		}
	}

}
