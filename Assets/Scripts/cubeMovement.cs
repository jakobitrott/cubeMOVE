using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeMovement : MonoBehaviour {

	// Use this for initialization
	public float z;
	Vector3 moveZ;

	public int changeSpeed = 3;
	
	// Update is called once per frame
	void Update () {

		z = transform.position.z;
		z++;
		moveZ = new Vector3 (transform.position.x, transform.position.y, z);
			transform.position = Vector3.MoveTowards(transform.position,moveZ,changeSpeed* Time.deltaTime);

	}
}
