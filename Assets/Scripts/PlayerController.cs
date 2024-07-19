using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
	[SerializeField] float speed;
	float rpm;
	[SerializeField] float horsePower = 0f;
	[SerializeField] float turnSpeed = 120f;
	float horizontalInput;
	float verticalInput;

	Rigidbody myRigidBody;
	[SerializeField] TextMeshProUGUI speedText;
	[SerializeField] TextMeshProUGUI rpmText;

	//[SerializeField] List<MeshCollider> allWheels;


	// Start is called before the first frame update
	void Start()
	{
		myRigidBody = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update()
	{
		// get user input
		horizontalInput = Input.GetAxis("Horizontal");
		verticalInput = Input.GetAxis("Vertical");
		// move the vehicle forward 
		//transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
		myRigidBody.AddRelativeForce(Vector3.forward * horsePower * verticalInput);
		speed = myRigidBody.velocity.magnitude * 3.6f;
		speedText.text = "Speed: " + speed.ToString("0") + " km/h";
		rpm = speed % 30 * 40;
		rpmText.text = "RPM: " + rpm.ToString("0");
		// rotate the vehicle
		transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
	}

	// bool IsOnGround()
	// {
	// 	int groundedWheels = 0;
	// 	foreach (MeshCollider wheel in allWheels)
	// 	{
	// 		if (wheel)
	// 		{
	// 			groundedWheels++;
	// 		}

	// 	}
	// 	if (groundedWheels == allWheels.Count)
	// 	{
	// 		return true;
	// 	}
	// 	else
	// 		return false;
	// }
}
