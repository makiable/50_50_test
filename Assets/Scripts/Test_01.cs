using UnityEngine;
using System.Collections;

public class Test_01 : MonoBehaviour {

	// 0 찾기 게임..

	public int a = 0;
	public int b = 0;

	public TextMesh mTextMash;



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
			Debug.Log("type="+type);
			if (a == 0) {
				Application.LoadLevel("Test_Success");
				Debug.Log("SS a");
			}
			else
				Application.LoadLevel("Test_Fail");
		}

		if (type == "1") {
			Debug.Log("type="+type);
			if (b == 0) {
				Application.LoadLevel("Test_Success");
			}
			else
				Application.LoadLevel("Test_Fail");
		}
	}
	
}
