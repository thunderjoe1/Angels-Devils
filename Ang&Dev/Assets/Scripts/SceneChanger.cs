using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

	int numberOfCalls = 0;

	void Update ()
	{
		if (ChoicesScript.demonAlarmPress())
		{
			numberOfCalls++;
		}
		if (numberOfCalls == 3) 
		{
			GameOver ();
			Debug.Log ("It's working bitches");
		}
	}

	void GameOver ()
	{
		LoadScene.GameOver;
	}



}



