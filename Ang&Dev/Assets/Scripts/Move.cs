using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour 
{

	public float speed;
	public float rotSpeed;


	void Update ()
	{
		float translation = Input.GetAxis ("Vertical") * speed;
		float rotation = Input.GetAxis ("Mouse X") * speed;


		translation *= Time.deltaTime * speed;
		rotation *= Time.deltaTime * rotSpeed;
		transform.Translate (0, 0, translation);
		transform.Rotate (0, rotation, 0);
	}


}
