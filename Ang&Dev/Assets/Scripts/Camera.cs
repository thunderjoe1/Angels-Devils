using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour 
{
	
	public float verticalSpeed = 2f;

	void Update ()
	{
		
		float v = -verticalSpeed * Input.GetAxis ("Mouse Y");
		transform.Rotate (v, 0, 0);
			

	}

}
