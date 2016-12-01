using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour 
{
	
	public float verticalSpeed = 2f;
	RaycastHit hit;
	public GameObject angelText; //The text that is displayed when hovering over the angel button.
	public GameObject demonText; //The text that is displayed when hovering over the demon button.
	Camera mainCamera;

	void Start ()
	{
		mainCamera = GetComponent<Camera> ();
	}

	void Update ()
	{
		if (Physics.Raycast(mainCamera.ScreenToWorldPoint(new Vector3((mainCamera.pixelHeight / 2), (mainCamera.pixelWidth / 2), 0)), transform.forward, out hit, 10f)) 
		{
			if (hit.collider.gameObject.CompareTag("angelButton")) 
			{
				angelText.SetActive (true);
				demonText.SetActive (false);
				if(Input.GetButtonDown("E"))
				{
					
				}

			} else if (hit.collider.gameObject.CompareTag("demonButton")) 
			{
				demonText.SetActive (true);
				angelText.SetActive (false);
				if (Input.GetButtonDown ("E")) 
				{
					
				}
			} else 
			{
				angelText.SetActive (false);
				demonText.SetActive (false);
			}
		}

		float v = -verticalSpeed * Input.GetAxis ("Mouse Y");
		transform.Rotate (v, 0, 0);
	}
}
