using UnityEngine;
using System.Collections;

public class DoorControl : MonoBehaviour {

	//컨트롤할 게임 메니저.
	public Test_01 mGameManager;

	//애니메이터 컨트롤 변수.
	private Animator mAnimator;

	// 상태 정의 
	public enum Status{
		Idle,
		Open,
		Close
	}

	// 애니메이션만 세팅 하면 된다.


	//트리거로 입력 받았을때 오픈 애니메이션을 보여준다. 0.5초 동안 

	// Use this for initialization
	void Start () {
		mAnimator = gameObject.GetComponent<Animator> ();
		Debug.Log (mAnimator);
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void SetStatus(Status status){

		switch (status) {
			case Status.Open:
				mAnimator.SetTrigger ("Open");

			Debug.Log("Send Open Massage");

				break;
				
		}
	}


}
