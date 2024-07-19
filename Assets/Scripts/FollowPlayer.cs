using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
	[SerializeField] GameObject player;
	Vector3 cameraTopOffset = new Vector3(0, 5, -7);
	Vector3 cameraFrontOffset = new Vector3(0, 1.8f, 1.3f);
	bool cameraFront = false;
	Vector3 offset;
	// Start is called before the first frame update
	void Start()
	{
		offset = cameraFront ? cameraFrontOffset : cameraTopOffset;
	}

	// Update is called once per frame
	void LateUpdate()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			offset = cameraFront ? cameraFrontOffset : cameraTopOffset;
			cameraFront = !cameraFront;
		}
		transform.position = player.transform.position + offset;

	}
}
