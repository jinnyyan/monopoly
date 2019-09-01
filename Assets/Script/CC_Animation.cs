using UnityEngine;
using System.Collections;

public class CC_Animation : MonoBehaviour {

	public Animator cc_Animator;
	public int CCnumber;

	public PlayController monopolyGame;
	private PlayMoving currentPlayer;

	// Use this for initialization

	void Start () {
		CCnumber = 0;
		currentPlayer = new PlayMoving ();
	}

	void Update () {
		animateCC ();
		currentPlayer = monopolyGame.GetCurrPlayer ();
	}

	private void animateCC(){
		StartCoroutine (ani_CC ());
	}
	
	IEnumerator ani_CC(){
		if (CCnumber==1 )
		{
			cc_Animator.SetTrigger ("refreshed");
			cc_Animator.SetInteger("pointer",1);
			CCnumber = 0;
			monopolyGame.getWallet(currentPlayer).addMoney(100);
			monopolyGame.consoleText = currentPlayer.getName() + " you inheirted $100";
		}
		if (CCnumber == 2) 
		{
			cc_Animator.SetTrigger ("refreshed");
			cc_Animator.SetInteger("pointer",2);
			CCnumber = 0;
			monopolyGame.getWallet(currentPlayer).addMoney(200);
			monopolyGame.consoleText = currentPlayer.getName() + " bank error in favor, collect $200";
		}
		if (CCnumber == 3) 
		{
			cc_Animator.SetTrigger ("refreshed");
			cc_Animator.SetInteger("pointer",3);
			CCnumber = 0;
			monopolyGame.getWallet(currentPlayer).subtractMoney(100);
			monopolyGame.consoleText = currentPlayer.getName() + " paid hospital $100";
		}
		if (CCnumber == 4) 
		{
			cc_Animator.SetTrigger ("refreshed");
			cc_Animator.SetInteger("pointer",4);
			CCnumber = 0;
			currentPlayer.forceNewLocation(40);
			monopolyGame.consoleText = currentPlayer.getName() + " is going to jail";
		}
		if (CCnumber == 5) 
		{
			cc_Animator.SetTrigger ("refreshed");
			cc_Animator.SetInteger("pointer",5);
			CCnumber = 0;
			monopolyGame.getWallet(currentPlayer).addMoney(10);
			monopolyGame.consoleText = currentPlayer.getName() + " won beauty contest, collect $10";
		}
		if (CCnumber == 6) 
		{
			cc_Animator.SetTrigger ("refreshed");
			cc_Animator.SetInteger("pointer",6);
			CCnumber = 0;
			var player_W = (PlayerWallet)monopolyGame.getWallet(currentPlayer);
			var incomeTax = (int)(player_W.getWalletAmount()*0.15);
			monopolyGame.getWallet(currentPlayer).addMoney(incomeTax);
			monopolyGame.consoleText = currentPlayer.getName() + " income tax refund";
		}
		if (Input.GetKeyDown (KeyCode.Delete)) 
		{
			cc_Animator.SetTrigger ("next");
		}
		yield return new WaitForEndOfFrame ();
	}
}
