using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

	public int numberOfCalls = 0;
	public GameObject gameManager;
	public ChoicesScript choicesScript;

	void Start(){

		choicesScript = gameManager.GetComponent<ChoicesScript> ();

	}

	void Update ()
	{
		if (choicesScript.demonPressed == true)
		{
			numberOfCalls++;
			choicesScript.demonPressed = false;
		}
		if (numberOfCalls == 3) 
		{
			GameOver ();
			Debug.Log ("It's working");
		}
	}

	void GameOver ()
	{
		SceneManager.LoadScene(0);
	}



}



