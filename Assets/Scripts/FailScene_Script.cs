using UnityEngine;
using System.Collections;

public class FailScene_Script : MonoBehaviour {

	public TextMesh mTextMesh;

	// Use this for initialization
	void Start () {
		mTextMesh.text = LiveDays.LiveDaysint.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
