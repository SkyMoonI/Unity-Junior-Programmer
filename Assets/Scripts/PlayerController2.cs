using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
	[SerializeField] float speed = 10f;
	[SerializeField] float turnSpeed = 120f;
	float horizontalInput;
	float verticalInput;
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			horizontalInput = -1;
		}
		else if (Input.GetKey(KeyCode.RightArrow))
		{
			horizontalInput = 1;
		}
		else
		{
			horizontalInput = 0;
		}
		if (Input.GetKey(KeyCode.UpArrow))
		{
			verticalInput = 1;
		}
		else if (Input.GetKey(KeyCode.DownArrow))
		{
			verticalInput = -1;
		}
		else
		{
			verticalInput = 0;
		}
		// move the vehicle forward 
		transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
		// rotate the vehicle
		transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
	}
}
