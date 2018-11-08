using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private float currentYPosition;
	private float lockedXPosition = -43f;
	private float lockedZPosition = -46f;
	public float speed;
	private bool movingDown = true;

	// Use this for initialization
	void Start () {		
		currentYPosition = gameObject.transform.position.y;
	}
	
	// Update is called once per frame
	void Update()
	{
		if (movingDown == true && currentYPosition == 35)
		{
			Debug.Log("Changed direction to false");
			movingDown = false;
		}
		if (movingDown == false && currentYPosition == 275)
		{
			Debug.Log("Changed direction to true");
			movingDown = true;
		}
	}


	void LateUpdate () {
		Debug.Log(movingDown);
		if (movingDown)
		{
			MoveBallDown();
		}
		else
		{
			MoveBallUp();
		}
		
	}

	void MoveBallDown()
	{
		currentYPosition -= speed;
		Debug.Log(currentYPosition);
		gameObject.transform.position = new Vector3(lockedXPosition, currentYPosition, lockedZPosition);
	}

	void MoveBallUp()
	{
		currentYPosition += speed;
		Debug.Log(currentYPosition);
		gameObject.transform.position = new Vector3(lockedXPosition, currentYPosition, lockedZPosition);
	}
}
