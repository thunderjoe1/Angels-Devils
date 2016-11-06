using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour 
{
	public GameObject testPlay, testQuit;
	void ClickPlay ()
	{
		testPlay.SetActive (true);
	}

	void ClickQuit ()
	{
		testQuit.SetActive (true);
	}


}
