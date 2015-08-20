using UnityEngine;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class Test_01 : MonoBehaviour {

	// 0 찾기 게임..

	public DoorControl BlackDoorControl;
	public DoorControl WhiteDoorControl;


	public int a = 0;
	public int b = 0;

	public TextMesh mTextMash;

	public enum Status{
		ChooseBlack,
		ChooseWhite
	}

	IEnumerator delayTime(){
		yield return new WaitForSeconds (5);
		Debug.Log ("Time = " + Time.time);
	}


	// Use this for initialization
	void Start () {

		a = Random.Range (0, 2);

		if (a == 0) {
			b = 1;
		} else
			b = 0;

		Debug.Log ("a="+ a);
		Debug.Log ("b="+ b);

		mTextMash.text = LiveDays.LiveDaysint.ToString();

	}
	void OnButtonDown(string type){
		Debug.Log("OnButtonDown");

		if (type == "0") {

			BlackDoorControl.SetStatus(DoorControl.Status.Open);

			Debug.Log("Open Black door__type="+type);


			if (a == 0) {
				Invoke("Sucess",1);
			}
			else
				Invoke("Fail",1);
		}

		if (type == "1") {

			WhiteDoorControl.SetStatus(DoorControl.Status.Open);

			Debug.Log("Open White door__typetype="+type);

			//yield return new WaitForSeconds(1.2f);

			if (b == 0) {
				Invoke("Sucess",1);
			}
			else
				Invoke("Fail",1);
		}
	}

	void Sucess(){
		Application.LoadLevel("Test_Success");
		Debug.Log("Success");
	}

	void Fail(){
		Application.LoadLevel("Test_Fail");
		Debug.Log ("Fail");
	}
	
}
