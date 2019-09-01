using UnityEngine;
using System.Collections;

public class Chance_Animation : MonoBehaviour {

	public PlayController monopolyGame;
	public Animator chance_Animator;
	public int ChanceNumber;

	private PlayMoving actingPlayer;

	// Use this for initialization

	void Start () {
		ChanceNumber = 0;
		actingPlayer = new PlayMoving ();
	}
	
	// Update is called once per frame
	void Update () {
		aniSearch ();
		actingPlayer = monopolyGame.GetCurrPlayer ();
	}

	private void aniSearch(){
		StartCoroutine (ani ());
	}

	IEnumerator ani(){
		if (ChanceNumber==1) 
		{
			chance_Animator.SetTrigger ("refreshed");
			chance_Animator.SetInteger("pointer",1);
			ChanceNumber = 0;
			monopolyGame.getWallet(actingPlayer).subtractMoney(15);
			monopolyGame.updateCV_money(15);
			monopolyGame.consoleText = actingPlayer.getName() + "paid $15 poor tax";
		}
		if (ChanceNumber==2) 
		{
			chance_Animator.SetTrigger ("refreshed");
			chance_Animator.SetInteger("pointer",2);
			ChanceNumber = 0;
			actingPlayer.forceNewLocation(0);
			monopolyGame.getWallet(actingPlayer).addMoney(200);
			monopolyGame.consoleText = actingPlayer.getName() + " adv. to GO with $200";
		}
		if (ChanceNumber==3) 
		{
			chance_Animator.SetTrigger ("refreshed");
			chance_Animator.SetInteger("pointer",3);
			ChanceNumber = 0;
			var nLoc = actingPlayer.currentSpaceNum - 3;
			if (nLoc < 0){
				nLoc = 40 + nLoc;
			}
			actingPlayer.forceNewLocation(nLoc);
			monopolyGame.consoleText = actingPlayer.getName() + " went back 3 spaces";
		}
		if (ChanceNumber==4) 
		{
			chance_Animator.SetTrigger ("refreshed");
			chance_Animator.SetInteger("pointer",4);
			ChanceNumber = 0;
			var otherPlayer = new PlayMoving();
			for (int i = 1; i < monopolyGame.GetPlayerList().Count; i++){
				otherPlayer =(PlayMoving)monopolyGame.GetPlayerList()[i];
				monopolyGame.getWallet(otherPlayer).addMoney(50);
				monopolyGame.getWallet(actingPlayer).subtractMoney(50);
			}
			monopolyGame.consoleText = actingPlayer.getName() + " became chairman, paid $50 to ea. player";
		}
		if (ChanceNumber==5) 
		{
			chance_Animator.SetTrigger ("refreshed");
			chance_Animator.SetInteger("pointer",5);
			ChanceNumber = 0;
			actingPlayer.forceNewLocation(40);
			monopolyGame.consoleText = actingPlayer.getName() + " is going to jail!";
		}
		if (ChanceNumber==6) 
		{
			chance_Animator.SetTrigger ("refreshed");
			chance_Animator.SetInteger("pointer",6);
			ChanceNumber = 0;
			monopolyGame.getWallet(actingPlayer).addMoney(150);
			monopolyGame.consoleText = actingPlayer.getName() + " building and loan matures, collect $150";
		}
		if (Input.GetKeyDown (KeyCode.Delete)) 
		{
			chance_Animator.SetTrigger ("next");
			monopolyGame.consoleText = "debug, Chance_next pressed";
		}
		yield return new WaitForEndOfFrame ();
	}
}
