using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour 
{

	public float speed;
	public float rotSpeed;


	void Update ()
	{
		float translationZ = Input.GetAxis ("Vertical") * speed * Time.deltaTime;
		float translationX = Input.GetAxis ("Horizontal") * speed * Time.deltaTime;
		float rotation = Input.GetAxis ("Mouse X") * rotSpeed * Time.deltaTime;

		transform.Translate (translationX, 0, translationZ);
		transform.Rotate (0, rotation, 0);
	}


}
