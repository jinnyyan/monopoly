using UnityEngine;
using System.Collections;

public class Dice2_Animation : MonoBehaviour {

	//float Start_time;
	//float Now_time;

	//bool start_to_count;

	public Animator m_Animator;
	public UIButton_DoMove d2;
	private int lastDice2Value;

	// Use this for initialization
	void Start () {
		lastDice2Value = 0;
		//Start_time = 0.0f;
		//Now_time = 0.0f;
		//start_to_count = false;
		//print (Screen.height);

	}
	
	// Update is called once per frame
	void Update () {
		if (d2.diceValue2 != lastDice2Value) {
			m_Animator.SetTrigger ("Roll");
			m_Animator.SetInteger ("pointer", d2.diceValue2);
			lastDice2Value = d2.diceValue2;
		}
	/*
		if (start_to_count) {
			Now_time = Time.timeSinceLevelLoad - Start_time;

			if(Now_time>1.5f){
				start_to_count=false;
				m_Animator.SetInteger("pointer",2);
			}
		}*/
	}
}
