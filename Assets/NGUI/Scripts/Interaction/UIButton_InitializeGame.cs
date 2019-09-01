//----------------------------------------------
//            NGUI: Next-Gen UI kit
// Copyright © 2011-2013 Tasharen Entertainment
//----------------------------------------------
using System.Collections;
using UnityEngine;

/// <summary>
/// Similar to UIButtonColor, but adds a 'disabled' state based on whether the collider is enabled or not.
/// </summary>

[AddComponentMenu("NGUI/Interaction/Button")]
public class UIButton_InitializeGame : UIButtonColor
{
	/// <summary>
	/// Color that will be applied when the button is disabled.
	/// </summary>

	public PlayController gameBoard;

	public Color disabledColor = Color.grey;

	/// <summary>
	/// If the collider is disabled, assume the disabled color.
	/// </summary>

	protected override void OnEnable ()
	{
		if (isEnabled) base.OnEnable();
		else UpdateColor(false, true);
	}

	public override void OnHover (bool isOver) { if (isEnabled) base.OnHover(isOver); }
	public override void OnPress (bool isPressed) { 
		if (isEnabled) base.OnPress(isPressed); 
		if (Input.GetMouseButtonUp (0)) {
			print ("Monopoly Game is being initialized!!");
			monopolyReset();
		}
	}


	private void monopolyReset(){
		gameBoard.gameContinue = true;
		gameBoard.consoleText = "Game has been reset!";
		gameBoard.updateCV_money(-gameBoard.getCV_money());
		//		count = 0;
		PlayMoving temp;
		PlayerWallet nuWallet;
		for (int i = 0; i < gameBoard.PlayerList.Count; i++){//move all the players back to GO
			temp = (PlayMoving)gameBoard.PlayerList[i];
			temp.forceNewLocation(0);
			temp.inJail = false;
		}
		for (int i = 0; i < gameBoard.WalletList.Count; i++) {
			nuWallet = (PlayerWallet)gameBoard.WalletList[i];
			nuWallet.setWalletAmount(1500);
			nuWallet.isBankrupt = false;
		}
		gameBoard.diceAccess.diceValue1 = 1;//place dice back at 1's
		gameBoard.diceAccess.diceValue2 = 1;
		gameBoard.LocationLibrary.clearLand();
		gameBoard.LocationLibrary.chanceDeck.ChanceNumber = 0;
		gameBoard.LocationLibrary.CCdeck.CCnumber = 0;
	}








	/// <summary>
	/// Whether the button should be enabled.
	/// </summary>
	/// 

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
