using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlattformController : MonoBehaviour {

	private float defaultRotation = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			defaultRotation -= 90;
			transform.rotation = Quaternion.Euler(0, defaultRotation, 0);
			
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			defaultRotation += 90;
			transform.rotation = Quaternion.Euler(0, defaultRotation, 0);

		}
	}
}
