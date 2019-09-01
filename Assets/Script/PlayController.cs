using UnityEngine;
using System.Collections;

public class PlayController : MonoBehaviour {

	public float MoveSpeed;
	public float RotationSpeed;

	public PlayMoving Shoe;
	public PlayMoving TopHat;
	public PlayMoving Thimble;
	public PlayMoving Battleship;

	public PlayerWallet ShoeWallet;
	public PlayerWallet TopHatWallet;
	public PlayerWallet ThimbleWallet;
	public PlayerWallet BattleshipWallet;

	public ArrayList PlayerList;
	public ArrayList WalletList;

	//public nLib LocationLibrary;
	public LibraryLib LocationLibrary;
	public UIButton_DoMove diceAccess; //~!!probably need to change
	public bool gameContinue;

	//public GUIText PlayerStatusGUI;
	//private string playStatsText; 
	public UILabel PlayerStatus;

	//public GUIText ConsoleGUI;
	public string consoleText;

	public UILabel Console_Text;
	public UILabel PlayOrder;
	public UILabel CommunityVault_Text;
	public UILabel CurrWinner;
	public UIButton_CheckWinner ChkWinner;

	private int CV_value;

	//PlayMoving[] players = FindObjectsOfType<PlayMoving>();

	//declared player objects
	/*
	public GameObject Shoe;
	public GameObject TopHat;
	public GameObject Thimble;
	public GameObject Battleship;

	public GameObject[] boardSpaceShoe;
	public GameObject[] boardSpaceTophat;
	public GameObject[] boardSpaceThimble;
	public GameObject[] boardSpaceBattleship;
	
	private bool Shoe_is_Moving;
	private bool TopHat_is_Moving;
	private bool Thimble_is_Moving;
	private bool Battleship_is_Moving;

	Vector3 ShoePosition ; Vector3 ShoeTarget ;
	Vector3 TopHatPosition ; Vector3 TopHatTarget ;
	Vector3 ThimblePosition ; Vector3 ThimbleTarget ;
	Vector3 BattleshipPosition ; Vector3 BattleshipTarget ;
	*/

	void Start () {
		CV_value = 0;
//		playStatsText = "";
		consoleText = "";
		gameContinue = true;

		Shoe.editName ("Shoe");
		TopHat.editName ("TopHat");
		Thimble.editName ("Thimble");
		Battleship.editName ("Battleship");

		PlayerList = new ArrayList ();
		PlayerList.Add (Shoe);
		PlayerList.Add (TopHat);
		PlayerList.Add (Thimble);
		PlayerList.Add (Battleship);

		WalletList = new ArrayList ();
		WalletList.Add (ShoeWallet);
		WalletList.Add (TopHatWallet);
		WalletList.Add (ThimbleWallet);
		WalletList.Add (BattleshipWallet);
		//print (Shoe.speed);
		//print (Battleship.speed);
		//Battleship.speed = 2.0f;
		//Battleship.SpeedUP ();
		
		//Hello HelloOnTopHat = TopHat.GetComponent<Hello> ();
		//TopHat.transform.position += new Vector3 (0.0f, -1.0f, 0.0f) * Time.deltaTime;
		//print (HellOnTopHat.speed);
		/*
		Shoe_is_Moving = false;
		TopHat_is_Moving = false;
		Thimble_is_Moving = false;
		Battleship_is_Moving = false;
		*/
	}
	//no longer in use (04AUG), all initialization occurs in UI_InitializeGame
	/*public void resetGame(){
		gameContinue = true;
		consoleText = "Game has been reset!";
		CV_value = 0;
//		count = 0;
		PlayMoving temp;
		PlayerWallet nuWallet;
		for (int i = 0; i < PlayerList.Count; i++){//move all the players back to GO
			temp = (PlayMoving)PlayerList[i];
			temp.forceNewLocation(0);
		}
		for (int i = 0; i < WalletList.Count; i++) {
			nuWallet = (PlayerWallet)WalletList[i];
			nuWallet.setWalletAmount(1500);
			nuWallet.isBankrupt = true;
			//give everyone1500
			//!!~~reset all landOwnership
		}
		diceAccess.diceValue1 = 1;//place dice back at 1's
		diceAccess.diceValue2 = 1;


	}*/



	//needs to be worked on to get pretty background
	void updateText(){
		//ConsoleText.text = "testing...: " + tempConsoleText;
		updatePlayerStats ();
//		ConsoleGUI.text = "testing: " + consoleText;
		updateConsoleText ();
		updatePlayOrder();
		updateCVtext ();
	}
	private void updateCurrWinner(){
		CurrWinner.text = ChkWinner.richestPlayer (PlayerList);
	}

	private void updateCVtext(){
		CommunityVault_Text.text = "$ " + CV_value;
	}
	public void updateCV_money(int thisMoney){
		CV_value = CV_value + thisMoney;
	}
	public int getCV_money(){
		return CV_value;
	}

	private void updatePlayerStats(){
		//PlayerStatusGUI.text 
		PlayerStatus.text = "Shoe: $" + ShoeWallet.getWalletAmount () + "\nTopHat: $" + TopHatWallet.getWalletAmount ()
			+ "\nThimble: $" + ThimbleWallet.getWalletAmount () + "\nBattleship: $" + BattleshipWallet.getWalletAmount ();
	}

	private void updateConsoleText(){
		//ConsoleGUI.text = consoleText;
		Console_Text.text = consoleText;
	}

	private void updatePlayOrder(){
		var thisPlayer = new PlayMoving();
		var tempText = "";
		for (int i =0; i < PlayerList.Count; i++){
			thisPlayer = (PlayMoving)PlayerList[i];
			tempText += thisPlayer.getName() + " ";
		}
		PlayOrder.text = tempText;
	}

	public void updateGameStatus(bool newStatus){ gameContinue = newStatus;}

	//private int count = 0;
	public bool getGameStatus(){
		//!!~~update winner
		//count++;
		//if (count > 100) {gameContinue = false;} //temp
		return gameContinue;
	}

	//advance PlayerOrder
	public void advPlayerOrder()
	{
		var tempPlayer = PlayerList[0];
		PlayerList.RemoveAt (0);
		PlayerList.Add (tempPlayer);
		print (PlayerList[0]);
	}
	
	public PlayMoving GetCurrPlayer(){	return PlayerList[0] as PlayMoving;	}

	public ArrayList GetPlayerList(){	return PlayerList; }

	public PlayerWallet getWallet(PlayMoving p){
		if (p == Shoe) {
		//	consoleText = "getting shoe wallet...";
			return ShoeWallet;
		} else if (p == Thimble) {
		//	consoleText = "getting thimble wallet...";
			return ThimbleWallet;
		} else if (p == TopHat) {
		//	consoleText = "getting tophat wallet...";
			return TopHatWallet;
		} else if (p == Battleship) {
		//	consoleText = "getting battleship wallet...";
			return BattleshipWallet;
		} else {
			consoleText = "error, wallet not found";
			return null;
		}
	}

	//~~~!!!need to create something to display the player order
	
	void Update () {
		updateText (); //updates various display logs
	}
}
