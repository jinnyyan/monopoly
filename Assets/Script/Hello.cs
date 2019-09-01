using UnityEngine;
using System.Collections;

public class Hello : MonoBehaviour {

	// Use this for initialization

	public int times =0;
	public float speed =1.0f;

	/*public SortedList boardSpaceList = new List<GameObject>(
		b0,b1,b2,b3,b4,b5,b6,b7,b8,b9,b10visit,b10in,b11,b12,b13,b14,b15,b16,b17,b18,b19,
		b20,b21,b22,b23,b24,b25,b26,b27,b28,b29,b30,b31,b32,b33,b34,b35,b36,b37,b38,b39
	; */



	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.W)) {
			gameObject.transform.position 
				+= new Vector3 (0.0f, 1.0f, 0.0f)*Time.deltaTime;
			print ("Now pressing W");
		}
		if (Input.GetKey (KeyCode.A)) {
			gameObject.transform.position 
				+= new Vector3 (-1.0f, 0.0f, 0.0f)*Time.deltaTime;
			print ("Now pressing A");
		}
		if (Input.GetKey (KeyCode.S)) {
			gameObject.transform.position 
				+= new Vector3 (0.0f, -1.0f, 0.0f)*Time.deltaTime;
			print ("Now pressing S");
		}
		if (Input.GetKey (KeyCode.D)) {
			gameObject.transform.position 
				+= new Vector3 (1.0f, 0.0f, 0.0f)*Time.deltaTime;
			print ("Now pressing D");
		}
	}
	public void Moving_To(Vector3 Target)
	{

	}
}
