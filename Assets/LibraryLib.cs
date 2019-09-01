using UnityEngine;
using System.Collections;

public class LibraryLib : MonoBehaviour {

	public ArrayList LocationList;
	public PlayController monopolyGame;

	public Chance_Animation chanceDeck;
	public CC_Animation CCdeck;

	//initialize a placeHolder for each boardSpace [format is an Array]
	private ArrayList bb;
	private ArrayList b0;
	private ArrayList b1;
	private ArrayList b2;
	private ArrayList b3;
	private ArrayList b4;
	private ArrayList b5;
	private ArrayList b6;
	private ArrayList b7;
	private ArrayList b8;
	private ArrayList b9;
	private ArrayList b10;
	private ArrayList b11;
	private ArrayList b12;
	private ArrayList b13;
	private ArrayList b14;
	private ArrayList b15;
	private ArrayList b16;
	private ArrayList b17;
	private ArrayList b18;
	private ArrayList b19;
	private ArrayList b20;
	private ArrayList b21;
	private ArrayList b22;
	private ArrayList b23;
	private ArrayList b24;
	private ArrayList b25;
	private ArrayList b26;
	private ArrayList b27;
	private ArrayList b28;
	private ArrayList b29;
	private ArrayList b30;
	private ArrayList b31;
	private ArrayList b32;
	private ArrayList b33;
	private ArrayList b34;
	private ArrayList b35;
	private ArrayList b36;
	private ArrayList b37;
	private ArrayList b38;
	private ArrayList b39;
	// Use this for initialization
	void Start () {
		//construct private locationSlots with special individual values
		LocationList = new ArrayList ();
		bb = new ArrayList (); b0 = new ArrayList (); b1 = new ArrayList (); b2 = new ArrayList ();
		b3 = new ArrayList (); b4 = new ArrayList (); b5 = new ArrayList (); b6 = new ArrayList ();
		b7 = new ArrayList (); b8 = new ArrayList (); b9 = new ArrayList (); b10 = new ArrayList ();
		b11 = new ArrayList (); b12 = new ArrayList ();
		b13 = new ArrayList (); b14 = new ArrayList (); b15 = new ArrayList (); b16 = new ArrayList ();
		b17 = new ArrayList (); b18 = new ArrayList (); b19 = new ArrayList (); b20 = new ArrayList ();
		b21 = new ArrayList (); b22 = new ArrayList ();
		b23 = new ArrayList (); b24 = new ArrayList (); b25 = new ArrayList (); b26 = new ArrayList ();
		b27 = new ArrayList (); b28 = new ArrayList (); b29 = new ArrayList (); b30 = new ArrayList ();
		b31 = new ArrayList (); b32 = new ArrayList ();
		b33 = new ArrayList (); b34 = new ArrayList (); b35 = new ArrayList (); b36 = new ArrayList ();
		b37 = new ArrayList (); b38 = new ArrayList (); b39 = new ArrayList (); b30 = new ArrayList ();

//property format: name:String, locIndex:Int, site:Int, ppBase:Int, hRent:Int, h2Rent:Int, h3Rent: Int, dis:District,~~owner, !!last elem will #houses			
		bb.Add("CommunityVault"); bb.Add(40);
		b0.Add("GoSpace"); b0.Add (0);b0.Add (0);
		b1.Add("Mediterranean Ave");b1.Add(1);  b1.Add(60);  b1.Add(2);  b1.Add(10);  b1.Add(30);  b1.Add(90);  //b1.Add (d1);
		b2.Add("Community Chest Space Side 1");b2.Add (2);
		b3.Add("Baltic Ave");b3.Add(3);  b3.Add(60);  b3.Add(4);  b3.Add(20);  b3.Add(60);  b3.Add(180); // b3.Add(d1);
		b4.Add("IncomeTax");b4.Add (4);b4.Add (0);
		b5.Add("Reading RR");b5.Add (5); b5.Add (200); b5.Add ("r");
		b6.Add("Oriental Ave");b6.Add(6);  b6.Add(100);  b6.Add(6);  b6.Add(30);  b6.Add(90);  b6.Add(270);  //b6.Add(d2);
		b7.Add("ChanceSpace");b7.Add (7); b7.Add (0);
		b8.Add("Vermont Ave");b8.Add(8);  b8.Add(100);  b8.Add(6);  b8.Add(30);  b8.Add(90);  b8.Add(270);  //b8.Add (d2);
		b9.Add("Connecticut Ave");b9.Add(9);  b9.Add(120);  b9.Add(8);  b9.Add (40); b9.Add (100);  b9.Add(300);  //b9.Add (d2);
		b10.Add("Jail");b10.Add (10);b10.Add (0);
		b11.Add("St. Charles Place");b11.Add(11);  b11.Add(140);  b11.Add(10);  b11.Add(50);  b11.Add(150);  b11.Add(450);  //b11.Add (d3);
		b12.Add("Electric Company");b12.Add (12); b12.Add (150); b12.Add ("u");
		b13.Add("States Ave");b13.Add(13);  b13.Add(140);  b13.Add(10);  b13.Add(50);  b13.Add(150);  b13.Add(450);  //b13.Add (d3);
		b14.Add("Virginia Ave");b14.Add(14);  b14.Add(160);  b14.Add(12);  b14.Add(60);  b14.Add(180);  b14.Add(500);  //b14.Add (d3);
		b15.Add("Pennsylvania RR");b15.Add (15); b15.Add (200); b15.Add ("r");
		b16.Add("St. James Place");b16.Add(16);  b16.Add(180);  b16.Add(14);  b16.Add(70);  b16.Add(200);  b16.Add(550); // b16.Add (d4);
		b17.Add("Community Chest Space Side 2");b17.Add (17); b17.Add (0);
		b18.Add("Tennessee Ave");b18.Add(18);  b18.Add(180);  b18.Add(14);  b18.Add(70);  b18.Add(200);  b18.Add(550);  //b18.Add (d4);
		b19.Add("New York Ave");b19.Add(19);  b19.Add(200);  b19.Add(16);  b19.Add(80);  b19.Add(220);  b19.Add(600); // b19.Add (d4);
		b20.Add("FreeParking"); b20.Add (20);b20.Add (0);
		b21.Add("Kentucky Ave");b21.Add(21);  b21.Add(220);  b21.Add(18);  b21.Add(90);  b21.Add(250);  b21.Add(700); // b21.Add (d5);
		b22.Add("Chance Space Side 3");b22.Add (22); b23.Add (0);
		b23.Add("Indiana Ave");b23.Add(23);  b23.Add(220);  b23.Add(18);  b23.Add(90);  b23.Add(250);  b23.Add(700); // b23.Add (d5);
		b24.Add("Illinois Ave");b24.Add(24);  b24.Add(240);  b24.Add(20);  b24.Add(100);  b24.Add(300);  b24.Add(750); // b24.Add (d5);
		b25.Add("B&O RR");b25.Add (25); b25.Add (200); b25.Add ("r");
		b26.Add("Atlantic Ave");b26.Add(26);  b26.Add(260);  b26.Add(22);  b26.Add(110);  b26.Add(330);  b26.Add(800); // b26.Add (d6);
		b27.Add("Ventnor Ave");b27.Add(27);  b27.Add(260);  b27.Add(22);  b27.Add(110);  b27.Add(330);  b27.Add(800); // b27.Add (d6);
		b28.Add("Water Works");b28.Add (28); b28.Add (150); b28.Add ("u");
		b29.Add("Marvins Garden");b29.Add(29);  b29.Add(280);  b29.Add(24);  b29.Add(120);  b29.Add(360);  b29.Add(850); // b29.Add (d6);
		b30.Add("GoToJail");b30.Add (30);b30.Add (0);
		b31.Add("Pacific Ave");b31.Add(31);  b31.Add(300);  b31.Add(26);  b31.Add(130);  b31.Add(390);  b31.Add(900); // b31.Add (d7);
		b32.Add("North Carolina Ave");b32.Add(32);  b32.Add(300);  b32.Add(26);  b32.Add(130);  b32.Add(390);  b32.Add(900); // b32.Add (d7);
		b33.Add("Community Chest Space Side 4");b33.Add (33); b33.Add (0);
		b34.Add("Pennsylvania Ave");b34.Add(34);  b34.Add(300);  b34.Add(28);  b34.Add(150);  b34.Add(450);  b34.Add(1000); // b34.Add (d7);
		b35.Add("Short Line RR");b35.Add (35); b35.Add (200); b35.Add ("r");
		b36.Add("Chance Space Side 4");b36.Add (36); b36.Add (0);
		b37.Add("Park Place");b37.Add(37);  b37.Add(350);  b37.Add(35);  b37.Add(175);  b37.Add(500);  b37.Add(1100); // b37.Add (d8);
		b38.Add("LuxuryTax");b38.Add (38);b38.Add (0);
		b39.Add("Boardwalk");b39.Add(39);  b39.Add(400);  b39.Add(50);  b39.Add(200);  b39.Add(800);  b39.Add(1400); // b39.Add (d8);


		LocationList.Add(b0);  LocationList.Add(b1);  LocationList.Add(b2);
		LocationList.Add(b3);  LocationList.Add(b4);  LocationList.Add(b5);  LocationList.Add(b6);
		LocationList.Add(b7);  LocationList.Add(b8);  LocationList.Add(b9);  LocationList.Add(b10);
		LocationList.Add(b11);  LocationList.Add(b12);
		LocationList.Add(b13);  LocationList.Add(b14);  LocationList.Add(b15);  LocationList.Add(b16);
		LocationList.Add(b17);  LocationList.Add(b18);  LocationList.Add(b19);  LocationList.Add(b20);
		LocationList.Add(b21);  LocationList.Add(b22);
		LocationList.Add(b23);  LocationList.Add(b24);  LocationList.Add(b25);  LocationList.Add(b26);
		LocationList.Add(b27);  LocationList.Add(b28);  LocationList.Add(b29);  LocationList.Add(b30);
		LocationList.Add(b31);  LocationList.Add(b32);
		LocationList.Add(b33);  LocationList.Add(b34);  LocationList.Add(b35);  LocationList.Add(b36);
		LocationList.Add(b37);  LocationList.Add(b38);  LocationList.Add(b39); LocationList.Add(bb);   
	
	}

/*	// Update is called once per frame
	void Update () {
	}*/
	public void clearLand(){
		bb.Clear(); b0.Clear(); b1.Clear(); b2.Clear();
		b3.Clear(); b4.Clear(); b5.Clear(); b6.Clear();
		b7.Clear(); b8.Clear(); b9.Clear(); b10.Clear();
		b11.Clear(); b12.Clear(); b13.Clear(); b14.Clear(); 
		b15.Clear(); b16.Clear(); b17.Clear(); b18.Clear();
		b19.Clear(); b20.Clear(); b21.Clear(); b22.Clear();
		b23.Clear(); b24.Clear(); b25.Clear(); b26.Clear();
		b27.Clear(); b28.Clear(); b29.Clear(); b30.Clear();
		b31.Clear(); b32.Clear(); b33.Clear(); b34.Clear(); 
		b35.Clear(); b36.Clear(); b37.Clear(); b38.Clear(); b39.Clear(); b30.Clear();

		LocationList.Clear ();

		bb.Add("CommunityVault"); bb.Add(40);
		b0.Add("GoSpace"); b0.Add (0);b0.Add (0);
		b1.Add("Mediterranean Ave");b1.Add(1);  b1.Add(60);  b1.Add(2);  b1.Add(10);  b1.Add(30);  b1.Add(90);  //b1.Add (d1);
		b2.Add("Community Chest Space Side 1");b2.Add (2);
		b3.Add("Baltic Ave");b3.Add(3);  b3.Add(60);  b3.Add(4);  b3.Add(20);  b3.Add(60);  b3.Add(180); // b3.Add(d1);
		b4.Add("IncomeTax");b4.Add (4);b4.Add (0);
		b5.Add("Reading RR");b5.Add (5); b5.Add (200); b5.Add ("r");
		b6.Add("Oriental Ave");b6.Add(6);  b6.Add(100);  b6.Add(6);  b6.Add(30);  b6.Add(90);  b6.Add(270);  //b6.Add(d2);
		b7.Add("ChanceSpace");b7.Add (7); b7.Add (0);
		b8.Add("Vermont Ave");b8.Add(8);  b8.Add(100);  b8.Add(6);  b8.Add(30);  b8.Add(90);  b8.Add(270);  //b8.Add (d2);
		b9.Add("Connecticut Ave");b9.Add(9);  b9.Add(120);  b9.Add(8);  b9.Add (40); b9.Add (100);  b9.Add(300);  //b9.Add (d2);
		b10.Add("Jail");b10.Add (10);b10.Add (0);
		b11.Add("St. Charles Place");b11.Add(11);  b11.Add(140);  b11.Add(10);  b11.Add(50);  b11.Add(150);  b11.Add(450);  //b11.Add (d3);
		b12.Add("Electric Company");b12.Add (12); b12.Add (150); b12.Add ("u");
		b13.Add("States Ave");b13.Add(13);  b13.Add(140);  b13.Add(10);  b13.Add(50);  b13.Add(150);  b13.Add(450);  //b13.Add (d3);
		b14.Add("Virginia Ave");b14.Add(14);  b14.Add(160);  b14.Add(12);  b14.Add(60);  b14.Add(180);  b14.Add(500);  //b14.Add (d3);
		b15.Add("Pennsylvania RR");b15.Add (15); b15.Add (200); b15.Add ("r");
		b16.Add("St. James Place");b16.Add(16);  b16.Add(180);  b16.Add(14);  b16.Add(70);  b16.Add(200);  b16.Add(550); // b16.Add (d4);
		b17.Add("Community Chest Space Side 2");b17.Add (17); b17.Add (0);
		b18.Add("Tennessee Ave");b18.Add(18);  b18.Add(180);  b18.Add(14);  b18.Add(70);  b18.Add(200);  b18.Add(550);  //b18.Add (d4);
		b19.Add("New York Ave");b19.Add(19);  b19.Add(200);  b19.Add(16);  b19.Add(80);  b19.Add(220);  b19.Add(600); // b19.Add (d4);
		b20.Add("FreeParking"); b20.Add (20);b20.Add (0);
		b21.Add("Kentucky Ave");b21.Add(21);  b21.Add(220);  b21.Add(18);  b21.Add(90);  b21.Add(250);  b21.Add(700); // b21.Add (d5);
		b22.Add("Chance Space Side 3");b22.Add (22); b23.Add (0);
		b23.Add("Indiana Ave");b23.Add(23);  b23.Add(220);  b23.Add(18);  b23.Add(90);  b23.Add(250);  b23.Add(700); // b23.Add (d5);
		b24.Add("Illinois Ave");b24.Add(24);  b24.Add(240);  b24.Add(20);  b24.Add(100);  b24.Add(300);  b24.Add(750); // b24.Add (d5);
		b25.Add("B&O RR");b25.Add (25); b25.Add (200); b25.Add ("r");
		b26.Add("Atlantic Ave");b26.Add(26);  b26.Add(260);  b26.Add(22);  b26.Add(110);  b26.Add(330);  b26.Add(800); // b26.Add (d6);
		b27.Add("Ventnor Ave");b27.Add(27);  b27.Add(260);  b27.Add(22);  b27.Add(110);  b27.Add(330);  b27.Add(800); // b27.Add (d6);
		b28.Add("Water Works");b28.Add (28); b28.Add (150); b28.Add ("u");
		b29.Add("Marvins Garden");b29.Add(29);  b29.Add(280);  b29.Add(24);  b29.Add(120);  b29.Add(360);  b29.Add(850); // b29.Add (d6);
		b30.Add("GoToJail");b30.Add (30);b30.Add (0);
		b31.Add("Pacific Ave");b31.Add(31);  b31.Add(300);  b31.Add(26);  b31.Add(130);  b31.Add(390);  b31.Add(900); // b31.Add (d7);
		b32.Add("North Carolina Ave");b32.Add(32);  b32.Add(300);  b32.Add(26);  b32.Add(130);  b32.Add(390);  b32.Add(900); // b32.Add (d7);
		b33.Add("Community Chest Space Side 4");b33.Add (33); b33.Add (0);
		b34.Add("Pennsylvania Ave");b34.Add(34);  b34.Add(300);  b34.Add(28);  b34.Add(150);  b34.Add(450);  b34.Add(1000); // b34.Add (d7);
		b35.Add("Short Line RR");b35.Add (35); b35.Add (200); b35.Add ("r");
		b36.Add("Chance Space Side 4");b36.Add (36); b36.Add (0);
		b37.Add("Park Place");b37.Add(37);  b37.Add(350);  b37.Add(35);  b37.Add(175);  b37.Add(500);  b37.Add(1100); // b37.Add (d8);
		b38.Add("LuxuryTax");b38.Add (38);b38.Add (0);
		b39.Add("Boardwalk");b39.Add(39);  b39.Add(400);  b39.Add(50);  b39.Add(200);  b39.Add(800);  b39.Add(1400); // b39.Add (d8);
		
		
		LocationList.Add(b0);  LocationList.Add(b1);  LocationList.Add(b2);
		LocationList.Add(b3);  LocationList.Add(b4);  LocationList.Add(b5);  LocationList.Add(b6);
		LocationList.Add(b7);  LocationList.Add(b8);  LocationList.Add(b9);  LocationList.Add(b10);
		LocationList.Add(b11);  LocationList.Add(b12);
		LocationList.Add(b13);  LocationList.Add(b14);  LocationList.Add(b15);  LocationList.Add(b16);
		LocationList.Add(b17);  LocationList.Add(b18);  LocationList.Add(b19);  LocationList.Add(b20);
		LocationList.Add(b21);  LocationList.Add(b22);
		LocationList.Add(b23);  LocationList.Add(b24);  LocationList.Add(b25);  LocationList.Add(b26);
		LocationList.Add(b27);  LocationList.Add(b28);  LocationList.Add(b29);  LocationList.Add(b30);
		LocationList.Add(b31);  LocationList.Add(b32);
		LocationList.Add(b33);  LocationList.Add(b34);  LocationList.Add(b35);  LocationList.Add(b36);
		LocationList.Add(b37);  LocationList.Add(b38);  LocationList.Add(b39); LocationList.Add(bb); 
	}

	public PlayerWallet getOwner (ArrayList qLand){
		//return (PlayerWallet)qLand [(qLand.Count - 1)];
		if (qLand [(qLand.Count - 1)] is PlayerWallet) {
			return (PlayerWallet)qLand [(qLand.Count - 1)];
		} else if (qLand [(qLand.Count - 2)] is PlayerWallet) {
			return (PlayerWallet)qLand [(qLand.Count - 2)];
		} else {
			return null;
		}
	}

	public int calculateRent(ArrayList leasedLand){
		if (((int)leasedLand [(leasedLand.Count - 1)]) < 4) {
			if (((int)leasedLand[(leasedLand.Count - 1)]) == 1){
				return (int)leasedLand[4];}
			else if (((int)leasedLand[(leasedLand.Count - 1)])==2){
				return (int)leasedLand[5];}
			else if (((int)leasedLand[(leasedLand.Count - 1)])==3){
				return (int)leasedLand[6];}
			else {return (int)leasedLand[3];}
		}
		return (int)leasedLand [3];
	}
	public bool isSpecialLand(ArrayList thisLand){
		if (((int)thisLand [1] == 0) || ((int)thisLand [1] == 2) || ((int)thisLand [1] == 4) || ((int)thisLand [1] == 5) ||
			((int)thisLand [1] == 7) || ((int)thisLand [1] == 10) || ((int)thisLand [1] == 12) || ((int)thisLand [1] == 17) ||
			((int)thisLand [1] == 15) || ((int)thisLand [1] == 20) || ((int)thisLand [1] == 22) || ((int)thisLand [1] == 25) ||
			((int)thisLand [1] == 28) || ((int)thisLand [1] == 30) || ((int)thisLand [1] == 33) || ((int)thisLand [1] == 35) ||
			((int)thisLand [1] == 36) || ((int)thisLand [1] == 38)) {
			return true; //locations cannot build house
		}
		return false;
	}
	public bool buildHouse(ArrayList upgradingLand){
		//check first to see if it is a valid land to build house (not jail, chance, railroad, utility)
		var tempHouseCount = (int)upgradingLand [(upgradingLand.Count - 1)];
		if (isSpecialLand (upgradingLand)) {
			return false; //locations cannot build house
		} else if (tempHouseCount < 3) {
			upgradingLand.RemoveAt (upgradingLand.Count - 1);
			tempHouseCount = tempHouseCount++;
			upgradingLand.Add (tempHouseCount);
			print ("house has been build");
			return true;
		} else {
			return false;
		}
	}
	public ArrayList getLand(int locIndex){
		return (ArrayList)LocationList[locIndex];
	}

	public void specialLandProcess(PlayMoving thePlayer, PlayerWallet theWallet, ArrayList spLand){
		var tempCounter = 0;
		//railroads
		if (((int)spLand [1] == 5) || ((int)spLand [1] == 15) || ((int)spLand [1] == 25) || ((int)spLand [1] == 35)) {
			var tempOwner = getOwner (spLand); //checks if the railroad is owned
			if (tempOwner != null) {
				for (int i = 0; i < theWallet.myLandList.Count-1; i++) {
					var tempArr = (ArrayList)theWallet.myLandList [i];
					if (tempArr [3].ToString () == "r") {
						tempCounter++;
					} 
				}
				getOwner (spLand).addMoney (tempCounter * 75);//probalby need to fix these lines for datastructures
				theWallet.subtractMoney (tempCounter * 75);
				print ("railroad rent paid");

			} else if (theWallet.getWalletAmount () > 200) {
				monopolyGame.LocationLibrary.getLand (thePlayer.currentSpaceNum).Add (theWallet);
				theWallet.subtractMoney (200);
				print (thePlayer.getName () + "bought railroad");
			} else {
				print ("player doesnt have enough money to buy railroad");
			}
		}

		//utility
		else if (((int)spLand [1] == 12) || ((int)spLand [1] == 28)) {
			var tempOwner = getOwner (spLand); //checks if the railroad is owned
			if (tempOwner != null) {
				for (int i = 0; i < theWallet.myLandList.Count-1; i++) {
					var tempArr = (ArrayList)theWallet.myLandList [i];
					if (tempArr [3].ToString () == "u") {
						tempCounter++;
					} 
				}
				var number = Random.Range (2, 12);
				getOwner (spLand).addMoney (tempCounter * 4 * number);//probalby need to fix these lines for datastructures
				theWallet.subtractMoney (tempCounter * 4 * number);
				print ("utilities paid");
				
			} else if (theWallet.getWalletAmount () > 150) {
				monopolyGame.LocationLibrary.getLand (thePlayer.currentSpaceNum).Add (theWallet);
				theWallet.subtractMoney (150);
				print (thePlayer.getName () + "bought utility");
			} else {
				print ("player doesnt have enough money to buy utility");
			}
		}

		//income tax --addmoney to communityvault
		else if ((int)spLand [1] == 4) {
			var tempMoney = (int)(theWallet.getWalletAmount () * 0.15);
			theWallet.subtractMoney (tempMoney);
			monopolyGame.updateCV_money (tempMoney);
			print ("taxes paid");
			monopolyGame.consoleText = thePlayer.getName () + " has paid taxes!";
		}

		//luxury tax
		else if ((int)spLand [1] == 38) {
			theWallet.subtractMoney (75);
			print ("luxury tax paid");
		}

		//community chest
		else if (((int)spLand [1] == 2) || ((int)spLand [1] == 17) || ((int)spLand [1] == 33)) {
			CCdeck.CCnumber = Random.Range (1, 7);
		}

		//chance
		else if (((int)spLand [1] == 7) || ((int)spLand [1] == 22) || ((int)spLand [1] == 36)) {
			chanceDeck.ChanceNumber = Random.Range (1, 7);
		} else if ((int)spLand [1] == 20) {//landed on free parking
			theWallet.addMoney (monopolyGame.getCV_money ());
			monopolyGame.updateCV_money (-monopolyGame.getCV_money ());
			print ("player cleared the community vault");
			monopolyGame.consoleText = "Community Vault has been emptied by: " + thePlayer.getName ();
		} else if (((int)spLand [1] == 0)) {
			monopolyGame.consoleText =  thePlayer.getName() + " is on GO! ";
			thePlayer.passedGO = true;
		}
		else{
			print ("merp, nothing special");
			//monopolyGame.consoleText = "Not a special place";
		}
	}
}
