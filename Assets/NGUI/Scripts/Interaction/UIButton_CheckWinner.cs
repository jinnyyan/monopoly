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
public class UIButton_CheckWinner : UIButtonColor
{
	/// <summary>
	/// Color that will be applied when the button is disabled.
	/// </summary>

	public Color disabledColor = Color.grey;

	public PlayController monopolyGame;

	public UILabel CurrentWinner_Label;

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
			var playList = monopolyGame.GetPlayerList();
			print ("winner is: "+ richestPlayer(playList));
		}
	}

	public string richestPlayer(ArrayList listOfPlayers){
		var highMoney = 0;
		var highPlayer = new PlayMoving();
		var tempPlayer = new PlayMoving ();
		for (int i = 0; i < listOfPlayers.Count; i++) {
			tempPlayer = (PlayMoving)listOfPlayers[i];
			print ("looking at: " + tempPlayer.getName());
			if (highMoney < monopolyGame.getWallet(tempPlayer).getWalletAmount()){
				highPlayer = tempPlayer;
				highMoney = monopolyGame.getWallet(tempPlayer).getWalletAmount();
			}
		}
		monopolyGame.consoleText = "high score found!";
		CurrentWinner_Label.text = highPlayer.getName ();
		return highPlayer.getName ();
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
