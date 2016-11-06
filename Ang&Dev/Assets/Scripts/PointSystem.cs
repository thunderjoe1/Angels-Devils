using UnityEngine;
using System.Collections;

public class PointSystem : MonoBehaviour 
{
	public int points; 



	void Awake ()
	{
		DontDestroyOnLoad (gameObject);
	}

}
