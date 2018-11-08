using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubesPlatformController : MonoBehaviour {

	private float defaultRotation = 0f;
	public float horizontalSpeed = 1f;

	// Use this for initialization
	void Start () {
		defaultRotation = gameObject.transform.rotation.y;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		defaultRotation -= Input.GetAxis("Mouse X") * horizontalSpeed;
		transform.rotation = Quaternion.Euler(0, defaultRotation, 0);
	}
}
