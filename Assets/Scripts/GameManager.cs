using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	//현재 레벨 표시.
	public int level = 0;

	//살아 남은 확률 표시.
	public float LivePersent = 0;
	

	// Use this for initialization
	void Start () {
		level = 0;
		LivePersent = 0f;
	}

		// Use this for initialization
	void OnButtonDown(string type){
		if (type == "Start") {
			Application.LoadLevel("Test_Game");
			LiveDays.LiveDaysint = 0;


		}

		if (type == "NextLevel") {
			Application.LoadLevel("Test_Game");
		}

		if (type == "Fail") {
			Application.LoadLevel("Start_Main");
			LiveDays.LiveDaysint = 0;
		}
	}


}
