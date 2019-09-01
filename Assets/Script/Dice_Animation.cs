using UnityEngine;
using System.Collections;

public class Dice_Animation : MonoBehaviour {

	//float Start_time;
	//float Now_time;

	//bool start_to_count;

	public Animator m_Animator;
	public UIButton_DoMove d1;
	private int lastDiceValue;

	// Use this for initialization
	void Start () {
		lastDiceValue = 0;
		//Start_time = 0.0f;
		//Now_time = 0.0f;
		//start_to_count = false;
		//print (Screen.height);

	}
	
	// Update is called once per frame
	void Update () {
		if (d1.diceValue1 != lastDiceValue) {
			m_Animator.SetTrigger ("Roll");
			m_Animator.SetInteger ("pointer", d1.diceValue1);
			lastDiceValue = d1.diceValue1;
		}
	/*	if (Input.GetKeyDown (KeyCode.Alpha1)) 
		{
			//start_to_count=true;
			//Start_time =Time.timeSinceLevelLoad;
			m_Animator.SetTrigger ("Roll");
			m_Animator.SetInteger("pointer",1);
		}
		if (Input.GetKeyDown (KeyCode.Alpha2)) 
		{
			m_Animator.SetTrigger ("Roll");
			m_Animator.SetInteger("pointer",2);
		}
		if (Input.GetKeyDown (KeyCode.Alpha3)) 
		{
			m_Animator.SetTrigger ("Roll");
			m_Animator.SetInteger("pointer",3);
		}
		if (Input.GetKeyDown (KeyCode.Alpha4)) 
		{
			m_Animator.SetTrigger ("Roll");
			m_Animator.SetInteger("pointer",4);
		}
		if (Input.GetKeyDown (KeyCode.Alpha5)) 
		{
			m_Animator.SetTrigger ("Roll");
			m_Animator.SetInteger("pointer",5);
		}
		if (Input.GetKeyDown (KeyCode.Alpha6)) 
		{
			m_Animator.SetTrigger ("Roll");
			m_Animator.SetInteger("pointer",6);
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
