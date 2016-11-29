using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ChoicesScript : MonoBehaviour 
{
	public GameObject angelText, demonText; //The gameobjects that have the text UI component. This is what the characters are saying.
	public GameObject angelButton, demonButton; //The gameobjects that have the text UI component. This is what the option buttons will say.
	public string angelTalk, demonTalk, angelButtonText, demonButtonText; //The actual strings that will be given to the above.
	public GameObject angelTest, demonTest; //Holds objects for testing purposes, please delete when game is done.
	public bool demonPressed;
	void Start () 
	{
		angelText.GetComponent<Text> ().text = angelTalk;			//Sets the propper text into the UI on load.
		demonText.GetComponent<Text> ().text = demonTalk;
		angelButton.GetComponent<Text> ().text = angelButtonText;
		demonButton.GetComponent<Text> ().text = demonButtonText;
		demonPressed = false;
		demonTest.SetActive (false);
	}
	void angelPress ()
	{
		
	}
	public void demonPress ()
	{
		demonTest.SetActive (true);
		demonPressed = true;
		
	}
}
